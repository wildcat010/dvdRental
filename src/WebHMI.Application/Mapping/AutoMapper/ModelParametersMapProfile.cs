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
    internal class ModelParametersMapProfile : Profile
    {
        public ModelParametersMapProfile()
        {
            CreateMap<MosParam, ParameterDto>().ReverseMap();
        }
    }
}
