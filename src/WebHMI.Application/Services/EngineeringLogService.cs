using Abp.Application.Services.Dto;
using Abp.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebHMI.Application.Dtos.EngineeringLogs;
using WebHMI.Dtos.Common;
using WebHMI.Dtos.EngineeringLogs;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebHMI.Application.Services
{
    public class EngineeringLogService : ApplicationServiceBase
    {
        private readonly IConfiguration _configuration;

        private readonly string _filePath;
        private readonly string _domain;
        private readonly string _username;
        private readonly string _password;
        public EngineeringLogService(IConfiguration configuration)
        {
            _configuration = configuration;

            var config = _configuration.GetSection("Impersonation");
            _domain = config["Domain"];
            _username = config["Username"];
            _password = config["Password"];
            _filePath = config["Path"];
        }

        private List<(string Name, DateTime Toc)> GetFileInfo() 
        {
            List<(string Name, DateTime Toc)> filesData = new List<(string, DateTime)>();

            ImpersonationHelper.Run(_domain, _username, _password, () =>
            {

                string[] files = Array.Empty<string>();
                try
                {
                    files = Directory.GetFiles(_filePath);

                }
                catch (Exception ex)
                {
                    throw new UserFriendlyException("Error during reading files from directory. ", ex.Message);
                }

                foreach (var filePath in files)
                {
                    var fileInfo = new FileInfo(filePath);
                    filesData.Add(new()
                    {
                        Name = fileInfo.Name,
                        Toc = fileInfo.CreationTimeUtc,
                    });
                }

            });

            return filesData;
        }

        private EngineeringLogDetailDto SplitFileData((string Name, DateTime Toc) fileData)
        {
            string[] dataChunks = new string[7];
            string[] dataSplitted = fileData.Name.Split('_');
            var detailDto = new EngineeringLogDetailDto();
            
            Array.Copy(dataSplitted, dataChunks, Math.Min(dataChunks.Length, dataSplitted.Length));
            
            detailDto.Name = fileData.Name;
            detailDto.CreationTime = fileData.Toc;
            detailDto.CoilId = dataChunks[0] + '_' + dataChunks[1];
            detailDto.CalcType = dataChunks[3];
            detailDto.PreCalc = !string.IsNullOrEmpty(dataChunks[5]) ? string.Concat(Regex.Matches(dataChunks[5], @"\d+")) : null;
            detailDto.PreCalcNumber = !string.IsNullOrEmpty(dataChunks[6]) ? string.Concat(Regex.Matches(dataChunks[6], @"\d+")) : null;
            
            return detailDto;
        }

        public async Task<PagedResultDto<EngineeringLogDetailDto>> GetAllData(FilteredRequestDto input)
        {
            var filesData = GetFileInfo();
            var result = new List<EngineeringLogDetailDto>();

            foreach (var file in filesData) 
            {
                result.Add(SplitFileData(file));
            }

            return ApplyFilter<EngineeringLogDetailDto, EngineeringLogDetailDto>(result.AsEnumerable()
                , input, (u) => {
                    return new EngineeringLogDetailDto()
                    {
                        Name = u.Name,
                        CreationTime = u.CreationTime,
                        CoilId = u.CoilId,
                        CalcType = u.CalcType,
                        PreCalc = u.PreCalc,
                        PreCalcNumber = u.PreCalcNumber
                    }; });

        }

        //public async Task<EngineeringLogDetailDto> GetDataById(string enOrExtId)
        //{
        //    var result = new EngineeringLogDetailDto();

        //    ImpersonationHelper.Run(_domain, _username, _password, () =>
        //    {
        //        string[] files = Array.Empty<string>();

        //        try
        //        {
        //            files = Directory.GetFiles(_filePath);

        //        }
        //        catch (Exception ex)
        //        {
        //            throw new UserFriendlyException("Error during reading files from directory. ", ex);
        //        }

        //        result = files
        //                .Where(file => Path.GetFileName(file).Contains(enOrExtId, StringComparison.OrdinalIgnoreCase))
        //                .Select(file =>
        //                {
        //                    var fileInfo = new FileInfo(file);
        //                    return new EngineeringLogDetailDto
        //                    {
        //                        Name = fileInfo.Name,
        //                        CreationTime = fileInfo.CreationTimeUtc,
        //                    };
        //                })
        //                .FirstOrDefault();

        //    });

        //    return result;
        //}

        public async Task<EngineeringLogItemDto> GetLogItem(string fileName)
        {
            var result = new EngineeringLogItemDto();

            ImpersonationHelper.Run(_domain, _username, _password, () =>
            {

                string[] files = Array.Empty<string>();

                try
                {
                    files = Directory.GetFiles(_filePath);

                }
                catch (Exception ex)
                {
                    throw new UserFriendlyException("Error during reading files from directory. ", ex.Message);
                }

                result = files
                            .Where(file => Path.GetFileName(file).Contains(fileName, StringComparison.OrdinalIgnoreCase))
                            .Select(file =>
                            {
                                var fileInfo = new FileInfo(file);
                                return new EngineeringLogItemDto
                                {
                                    Data = File.ReadAllText(file),
                                    Details = SplitFileData((fileInfo.Name, fileInfo.CreationTime))
                                };
                            })
                            .FirstOrDefault();

            });

            return result;
        }
    }
}
