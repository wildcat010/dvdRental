using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
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
            return await ApplyFilter<Mosparam, ParameterDto>(_prdbContext.Mosparams
                                    .OrderByDescending(t => t.Toc), input);
        }

        /// <summary>
        /// Function to get single parameter by given Id
        /// </summary>
        [AbpAuthorize(Permissions.Pages_Parameters)]
        public async Task<ParameterDto> Get(ParameterKeyDto input)
        {
            var parameter = await _prdbContext.Mosparams
                .FirstOrDefaultAsync(x => x.Paramname == input.ParamName && x.Planttype == input.PlantType.ToString());

            if (parameter == null)
            {
                throw new EntityNotFoundException(typeof(ParameterDto), input);
            }

            return MapToEntityDto<Mosparam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Create single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> CreateAsync(ParameterDto limitDto)
        {
            var parameter = ObjectMapper.Map<Mosparam>(limitDto);
            _prdbContext.Mosparams.Add(parameter);

            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.ModelParameter, limitDto.Planttype);

            return MapToEntityDto<Mosparam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Update single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> UpdateAsync(ParameterDto input)
        {
            var parameter = await _prdbContext.Mosparams.FirstOrDefaultAsync(x => x.Paramname == input.ParamName && x.Planttype == input.PlantType);

            if (parameter is null)
                throw new EntityNotFoundException("Model param not found");

            var callArguments = new ParamsDto()
            {
                PlantType = input.PlantType,
                Name = input.ParamName,
                DisplayName = input.ParamName,
                UserName = "user",
                OldUValue = parameter.Curvaln?.ToString() ?? parameter.Curvalc,
                OldLValue = "",
                NewUValue = input.CurValN?.ToString() ?? input.CurValC,
                NewLValue = ""
            };

            parameter = ObjectMapper.Map<Mosparam>(input);
            await CurrentUnitOfWork.SaveChangesAsync();

            _l2Sender.SendProcessParametersUpdated(callArguments);

            return MapToEntityDto<Mosparam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Delete single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task DeleteAsync(ParameterKeyDto input)
        {
            var parameters = _prdbContext.Mosparams.Where(x => x.Paramname == input.ParamName && x.Planttype == input.PlantType.ToString());
            _prdbContext.Mosparams.RemoveRange(parameters);
            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.ModelParameter, input.Planttype);
        }
    }
}
