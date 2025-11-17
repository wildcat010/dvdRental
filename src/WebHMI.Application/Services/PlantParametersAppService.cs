using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.AutoMapper;
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
using WebHMI.L2Adapter.Common;
using WebHMI.L2Adapter.Dtos;
using WebHMI.L2Adapter.Senders;
using WebHMI.Mapping.Extensions;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

#pragma warning disable RS0030

namespace WebHMI.Services
{
    [AbpAuthorize(Permissions.Pages_Parameters)]
    public class PlantParametersAppService : ApplicationServiceBase
    {
        private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;
        private PrdbContext _prdbContext => _prdbContextProvider.GetDbContext();
        private readonly IL2CommunicationHandler _l2Sender;

        public PlantParametersAppService(
            IL2CommunicationHandler l2Sender,
            IDbContextProvider<PrdbContext> prdbContextProvider)
        {
            _l2Sender = l2Sender;
            _prdbContextProvider = prdbContextProvider;
        }

        /// <summary>
        /// Function to get all plant parameters
        /// </summary>
        /// <returns></returns>
        public async Task<PagedResultDto<ParameterDto>> GetAll(FilteredRequestDto input)
        {
            return await ApplyFilter<PlantParam, ParameterDto>(_prdbContext.PlantParams
                                    .OrderByDescending(t => t.Toc), input, PlantParameterMapper.MapToDto);
        }

        /// <summary>
        /// Function to get single parameter by given Id
        /// </summary>
        public async Task<ParameterDto> Get(ParameterKeyDto input)
        {
            var parameter = await _prdbContext.PlantParams
                .FirstOrDefaultAsync(x => x.ParamName == input.ParamName && x.PlantType == input.PlantType.ToString())
                ?? throw new EntityNotFoundException(typeof(ParameterKeyDto), input);

            return parameter.MapToDto();
        }

        /// <summary>
        /// Create single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> CreateAsync(ParameterDto input)
        {
            var parameter = input.MapToDbo();
            _prdbContext.PlantParams.Add(parameter);
            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.PlantParameter, input.Planttype);

            return parameter.MapToDto();
        }

        /// <summary>
        /// Update single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task<ParameterDto> UpdateAsync(ParameterDto input)
        {
            var parameter = await _prdbContext.PlantParams
                .FirstOrDefaultAsync(x => x.ParamName == input.ParamName && x.PlantType == input.PlantType)
                ?? throw new EntityNotFoundException("Plant parameter not found");

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

            parameter.CType = input.CType;
            parameter.CurValC = input.CurValC;
            parameter.CurValN = (float)input.CurValN;
            parameter.Description = input.Description;
            parameter.Moddescr = input.Moddescr;
            parameter.Unit = input.Unit;

            await CurrentUnitOfWork.SaveChangesAsync();

            _l2Sender.SendProcessParametersUpdated(callArguments);

            return parameter.MapToDto() ;
        }

        /// <summary>
        /// Delete single parameter async method
        /// </summary>
        [Audited]
        [AbpAuthorize(Permissions.Pages_Parameters_Edit)]
        public async Task DeleteAsync(ParameterKeyDto input)
        {
            var parameters = await _prdbContext.PlantParams
                .Where(x => x.ParamName == input.ParamName && x.PlantType == input.PlantType.ToString())
                .ToListAsync();

            _prdbContext.PlantParams.RemoveRange(parameters);

            await CurrentUnitOfWork.SaveChangesAsync();

            //_l2Sender.SendProcessParametersUpdated(XIDL.HmiParamCategory.PlantParameter, input.Planttype);
        }
    }
}
