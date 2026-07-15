using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Limit;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    internal static class LimitMapper
    {
        public static LimitDto MapToDto(this PlantLimit dbo) 
        {
            var dto = new LimitDto();
            dto.LimitName = dbo.LimitName;
            dto.PlantType = dbo.PlantType;
            dto.CType = dbo.CType;
            dto.Description = dbo.Description;
            dto.LowerLimit = dbo.LowerLimit;
            dto.Moddescr = dbo.Moddescr;
            dto.SortOrder = dbo.SortOrder;
            dto.Unit = dbo.Unit;
            dto.UpperLimit = dbo.UpperLimit;
            dto.Toc = dbo.Toc;
            dto.Tom = dbo.Tom;
            dto.Mop = dbo.Mop;

            return dto;
        }

        public static PlantLimit MapToDbo(this LimitDto dto)
        {
            var dbo = new PlantLimit();
            dbo.LimitName = dto.LimitName;
            dbo.PlantType = dto.PlantType;
            dbo.CType = dto.CType;
            dbo.Description = dto.Description;
            dbo.LowerLimit = dto.LowerLimit;
            dbo.Moddescr = dto.Moddescr;
            dbo.SortOrder = dto.SortOrder;
            dbo.Unit = dto.Unit;
            dbo.UpperLimit = dto.UpperLimit;
            dbo.Toc = dto.Toc;
            dbo.Tom = dto.Tom;
            dbo.Mop = dto.Mop;

            return dbo;
        }
    }
}
