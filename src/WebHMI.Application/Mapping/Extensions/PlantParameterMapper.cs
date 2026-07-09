using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Parameters;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
    internal static class PlantParameterMapper
    {
        public static ParameterDto MapToDto(this Plantparam dbo) 
        {
            var dto = new ParameterDto();
            dto.ParamName = dbo.Paramname;
            dto.PlantType = dbo.Planttype;
            dto.CType = dbo.Ctype;
            dto.CurValC = dbo.Curvalc;
            dto.CurValN = dbo.Curvaln;
            dto.Description = dbo.Description;
            dto.Moddescr = dbo.Moddescr;
            dto.Unit = dbo.Unit;

            return dto;
        }
        public static Plantparam MapToDbo(this ParameterDto dto)
        {
            var dbo = new Plantparam();
            dbo.Paramname = dto.ParamName;
            dbo.Planttype = dto.PlantType;
            dbo.Ctype = dto.CType;
            dbo.Curvalc = dto.CurValC;
            dbo.Curvaln = (float)dto.CurValN;
            dbo.Description = dto.Description;
            dbo.Moddescr = dto.Moddescr;
            dbo.Unit = dto.Unit;

            return dbo;
        }
    }
}
