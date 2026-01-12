using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.UI;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebHMI.Application.Dtos.EngineeringLogs;
using WebHMI.Dtos.EngineeringLogs;
using WebHMI.Filters;
using WebHMI.Helpers;
namespace WebHMI.Application.Services
{
    public class EngineeringLogService : ApplicationServiceBase
    {
        private readonly IConfiguration _configuration;

        private readonly string _filePath;
        private readonly string _csFilePath;
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
            _csFilePath = config["PathCS"];
        }

        private List<(string Name, DateTime Toc)> GetFileInfo(string filePath) 
        {
            List<(string Name, DateTime Toc)> filesData = new List<(string, DateTime)>();

            ImpersonationHelper.Run(_domain, _username, _password, () =>
            {

                string[] files = Array.Empty<string>();
                try
                {
                    files = Directory.GetFiles(filePath);

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

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM)]
        private List<EngineeringLogDetailDto> GetAllLogs(string path, Func<(string Name, DateTime Toc), EngineeringLogDetailDto> parser)
            {
                var filesData = GetFileInfo(path);
                return filesData.Select(parser).ToList();
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<EngineeringLogDetailDto>> GetAllData(FilteredRequestDto input)
        {
            var result = GetAllLogs(_filePath, SplitFileData);

            return ApplyFilter<EngineeringLogDetailDto,EngineeringLogDetailDto>(result.AsEnumerable(), input, u => u);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public async Task<PagedResultDto<EngineeringLogDetailDto>> GetAllDataCS(FilteredRequestDto input)
        {
            var result = GetAllLogs(_csFilePath, SplitFileDataCS);
            return ApplyFilter<EngineeringLogDetailDto, EngineeringLogDetailDto>(result.AsEnumerable(), input, u => u);

        }

        private EngineeringLogItemDto GetSingleLog(string path, string fileName, Func<(string Name, DateTime Toc), EngineeringLogDetailDto> parser)
        {
            EngineeringLogItemDto result = null;

            ImpersonationHelper.Run(_domain, _username, _password, () =>
            {
                try
                {
                    var file = Directory.GetFiles(path)
                        .FirstOrDefault(f => Path.GetFileName(f)
                        .Contains(fileName, StringComparison.OrdinalIgnoreCase));

                    if (file == null) return;

                    var fileInfo = new FileInfo(file);
                    result = new EngineeringLogItemDto
                    {
                        Data = File.ReadAllText(file),
                        Details = parser((fileInfo.Name, fileInfo.CreationTimeUtc))
                    };
                }
                catch (Exception ex)
                {
                    throw new UserFriendlyException($"Error during reading file '{fileName}'.", ex.Message);
                }
            });

            return result;
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public EngineeringLogItemDto GetLogItem(string fileName)
        {
            return GetSingleLog(_filePath, fileName, SplitFileData);
        }

        [AbpAuthorize(Permissions.Pages_Setpoints_FM, Permissions.Pages_Setpoints_RM, Permissions.Pages_PrimaryData)]
        public EngineeringLogItemDto GetLogItemCS(string fileName)
        {
            return GetSingleLog(_csFilePath, fileName, SplitFileDataCS);
        }

        private EngineeringLogDetailDto SplitFileData((string Name, DateTime Toc) fileData)
        {
            var chunks = fileData.Name.Split('_');
            var dto = new EngineeringLogDetailDto
            {
                Name = fileData.Name,
                CreationTime = fileData.Toc,
                CoilId = chunks.ElementAtOrDefault(0) + "_" + chunks.ElementAtOrDefault(1),
                CalcType = chunks.ElementAtOrDefault(3),
                PreCalc = Regex.Match(chunks.ElementAtOrDefault(5) ?? "", @"\d+").Value,
                PreCalcNumber = Regex.Match(chunks.ElementAtOrDefault(6) ?? "", @"\d+").Value
            };
            return dto;
        }

        private EngineeringLogDetailDto SplitFileDataCS((string Name, DateTime Toc) fileData)
        {
            var chunks = fileData.Name.Split('_', '.');
            var dto = new EngineeringLogDetailDto
            {
                Name = fileData.Name,
                CreationTime = fileData.Toc,
                CoilId = chunks.ElementAtOrDefault(1) + "_" + chunks.ElementAtOrDefault(2),
            };
            return dto;
        }

    }
}
