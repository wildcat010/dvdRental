using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Limit;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.AutoMapper
{
    public class LimitsMapProfile : Profile
    {
        public LimitsMapProfile()
        {
            CreateMap<LimitDto, Plantlimit>()
                .ReverseMap();

            CreateMap<CreateLimitDto, Plantlimit>();

            CreateMap<DeleteLimitDto, Plantlimit>();
        }
    }
}
