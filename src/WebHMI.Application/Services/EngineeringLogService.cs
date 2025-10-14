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
using System.Threading.Tasks;
using WebHMI.Application.Dtos.EngineeringLogs;
using WebHMI.Dtos.EngineeringLogs;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task<List<EngineeringLogDetailDto>> GetAllData()
        {
            var result = new List<EngineeringLogDetailDto>();

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
                    result.Add(new EngineeringLogDetailDto
                    {
                        Name = fileInfo.Name,
                        CreationTime = fileInfo.CreationTimeUtc,
                    });
                }

                
            });

            return result;

        }

        public async Task<EngineeringLogDetailDto> GetDataById(string enOrExtId)
        {
            var result = new EngineeringLogDetailDto();

            ImpersonationHelper.Run(_domain, _username, _password, () =>
            {
                string[] files = Array.Empty<string>();

                try
                {
                    files = Directory.GetFiles(_filePath);

                }
                catch (Exception ex)
                {
                    throw new UserFriendlyException("Error during reading files from directory. ", ex);
                }

                result = files
                        .Where(file => Path.GetFileName(file).Contains(enOrExtId, StringComparison.OrdinalIgnoreCase))
                        .Select(file =>
                        {
                            var fileInfo = new FileInfo(file);
                            return new EngineeringLogDetailDto
                            {
                                Name = fileInfo.Name,
                                CreationTime = fileInfo.CreationTimeUtc,
                            };
                        })
                        .FirstOrDefault();

            });

            return result;
        }

        public async Task<EngineeringLogItemDto> GetLogItem(string enOrExtId)
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
                            .Where(file => Path.GetFileName(file).Contains(enOrExtId, StringComparison.OrdinalIgnoreCase))
                            .Select(file =>
                            {
                                var fileInfo = new FileInfo(file);
                                return new EngineeringLogItemDto
                                {
                                    Data = File.ReadAllText(file),
                                    Details = new EngineeringLogDetailDto
                                    {
                                        Name = fileInfo.Name,
                                        CreationTime = fileInfo.CreationTimeUtc,
                                    }
                                };
                            })
                            .FirstOrDefault();

            });
            return result;
        }
    }
}
