using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebHMI.Dtos.Limit;
using WebHMI.Dtos.Parameters;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

#pragma warning disable RS0030

namespace WebHMI.Services
{
    public class ModelParametersAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IL2CommunicationHandler _l2Sender;

        public ModelParametersAppService(
            IL2CommunicationHandler l2Sender,
            IDbContextProvider<PrdbContext> prdbContextProvider)
        {
            _l2Sender = l2Sender;
            _prdbContextProvider = prdbContextProvider;
        }

        /// <summary>
        /// Function to get all model parameters
        /// </summary>
        /// <returns></returns>
        [AbpAuthorize(Permissions.Pages_Parameters)]
        public async Task<PagedResultDto<ParameterDto>> GetAll(FilteredRequestDto input)
        {
            return await ApplyFilter<MosParam, ParameterDto>(_prdbContext.MosParams
                                    .OrderByDescending(t => t.Toc), input);
        }

        /// <summary>
        /// Function to get single parameter by given Id
        /// </summary>
        [AbpAuthorize(Permissions.Pages_Parameters)]
        public async Task<ParameterDto> Get(ParameterKeyDto input)
        {
            var parameter = await _prdbContext.MosParams
                .FirstOrDefaultAsync(x => x.ParamName == input.ParamName && x.PlantType == input.PlantType.ToString());

            if (parameter == null)
            {
                throw new EntityNotFoundException(typeof(ParameterDto), input);
            }

            return MapToEntityDto<MosParam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Create single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> CreateAsync(ParameterDto limitDto)
        {
            var parameter = ObjectMapper.Map<MosParam>(limitDto);
            _prdbContext.MosParams.Add(parameter);

            await CurrentUnitOfWork.SaveChangesAsync();

            var callArguments = new ParamsDto()
            {
                PlantType = limitDto.PlantType,
                Name = limitDto.ParamName,
                DisplayName = limitDto.ParamName,
                UserName = "user",
                OldUValue = parameter.CurValN?.ToString() ?? parameter.CurValC,
                OldLValue = "",
                NewUValue = limitDto.CurValN?.ToString() ?? limitDto.CurValC,
                NewLValue = ""
            };

            _l2Sender.SendProcessParametersUpdated(callArguments);

            return MapToEntityDto<MosParam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Update single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> UpdateAsync(ParameterDto input)
        {
            var parameter = await _prdbContext.MosParams.FirstOrDefaultAsync(x => x.ParamName == input.ParamName && x.PlantType == input.PlantType);

            if (parameter is null)
                throw new EntityNotFoundException("Model param not found");

            var callArguments = new ParamsDto()
            {
                PlantType = input.PlantType,
                Name = input.ParamName,
                DisplayName = input.ParamName,
                UserName = "user",
                OldUValue = parameter.CurValN?.ToString() ?? parameter.CurValC,
                OldLValue = "",
                NewUValue = input.CurValN?.ToString() ?? input.CurValC,
                NewLValue = ""
            };

            ObjectMapper.Map(input, parameter);
            await CurrentUnitOfWork.SaveChangesAsync();

            _l2Sender.SendProcessParametersUpdated(callArguments);

            return MapToEntityDto<MosParam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Delete single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task DeleteAsync(ParameterKeyDto input)
        {
            var parameters = _prdbContext.MosParams.Where(x => x.ParamName == input.ParamName && x.PlantType == input.PlantType.ToString());
            _prdbContext.MosParams.RemoveRange(parameters);
            await CurrentUnitOfWork.SaveChangesAsync();

            var callArguments = new ParamsDto()
            {
                PlantType = input.PlantType,
                Name = input.ParamName,
                DisplayName = "",
                UserName = "user",
                OldUValue = "",
                OldLValue = "",
                NewUValue = "",
                NewLValue = ""
            };

            _l2Sender.SendProcessParametersUpdated(callArguments);
        }
    }
}
