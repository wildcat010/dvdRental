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
        public static LimitDto MapToDto(this Plantlimit dbo) 
        {
            var dto = new LimitDto();
            dto.LimitName = dbo.Limitname;
            dto.PlantType = dbo.Planttype;
            dto.CType = dbo.Ctype;
            dto.Description = dbo.Description;
            dto.LowerLimit = dbo.Lowerlimit;
            dto.Moddescr = dbo.Moddescr;
            dto.SortOrder = dbo.Sortorder;
            dto.Unit = dbo.Unit;
            dto.UpperLimit = dbo.Upperlimit;
            dto.Toc = dbo.Toc;
            dto.Tom = dbo.Tom;
            dto.Mop = dbo.Mop;

            return dto;
        }

        public static Plantlimit MapToDbo(this LimitDto dto)
        {
            var dbo = new Plantlimit();
            dbo.Limitname = dto.LimitName;
            dbo.Planttype = dto.PlantType;
            dbo.Ctype = dto.CType;
            dbo.Description = dto.Description;
            dbo.Lowerlimit = dto.LowerLimit;
            dbo.Moddescr = dto.Moddescr;
            dbo.Sortorder = dto.SortOrder;
            dbo.Unit = dto.Unit;
            dbo.Upperlimit = dto.UpperLimit;
            dbo.Toc = dto.Toc;
            dbo.Tom = dto.Tom;
            dbo.Mop = dto.Mop;

            return dbo;
        }
    }
}
