using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Parameters;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.AutoMapper
{
    internal class PlantParamMapProfile : Profile
    {
        public PlantParamMapProfile()
        {
            CreateMap<Plantparam, ParameterDto>().ReverseMap();

            CreateMap<Plantparam, ParameterKeyDto>().ReverseMap();
        }
    }
}
