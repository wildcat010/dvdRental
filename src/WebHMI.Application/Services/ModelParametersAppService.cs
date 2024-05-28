using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using AutoMapper.Internal.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Parameters;
using WebHMI.Filters;
using WebHMI.Helpers;
using WebHMI.L2Adapter.Senders;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

#pragma warning disable RS0030

namespace WebHMI.Services
{
    [AbpAuthorize(Permissions.Pages_Parameters)]
    public class ModelParametersAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IL2Sender _l2Sender;

        public ModelParametersAppService(
            IL2Sender l2Sender,
            IDbContextProvider<PrdbContext> prdbContextProvider)
        {
            _l2Sender = l2Sender;
            _prdbContextProvider = prdbContextProvider;
        }

        /// <summary>
        /// Function to get all model parameters
        /// </summary>
        /// <returns></returns>
        public async Task<PagedResultDto<ParameterDto>> GetAll(FilteredRequestDto input)
        {
            return await ApplyFilter<MosParam, ParameterDto>(_prdbContext.MosParams
                                    .OrderByDescending(t => t.Toc), input);
        }

        /// <summary>
        /// Function to get single parameter by given Id
        /// </summary>
        public async Task<ParameterDto> Get(ParameterKeyDto input)
        {
            var parameter = await _prdbContext.MosParams.FirstOrDefaultAsync(x => x.ParamName == input.Paramname && x.PlantType == input.Planttype.ToString());

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

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.ModelParameter, limitDto.Planttype);

            return MapToEntityDto<MosParam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Update single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> UpdateAsync(ParameterDto input)
        {
            var parameter = await _prdbContext.MosParams.FirstOrDefaultAsync(x => x.ParamName == input.Paramname && x.PlantType == input.Planttype);

            if (parameter is null)
                throw new EntityNotFoundException("Model param not found");

            parameter = ObjectMapper.Map<MosParam>(input);
            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.ModelParameter, input.Planttype);

            return MapToEntityDto<MosParam, ParameterDto>(parameter);
        }

        /// <summary>
        /// Delete single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task DeleteAsync(ParameterKeyDto input)
        {
            var parameters = _prdbContext.MosParams.Where(x => x.ParamName == input.Paramname && x.PlantType == input.Planttype.ToString());
            _prdbContext.MosParams.RemoveRange(parameters);
            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.ModelParameter, input.Planttype);
        }
    }
}
