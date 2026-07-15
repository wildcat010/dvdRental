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
        public static ParameterDto MapToDto(this PlantParam dbo) 
        {
            var dto = new ParameterDto();
            dto.ParamName = dbo.ParamName;
            dto.PlantType = dbo.PlantType;
            dto.CType = dbo.CType;
            dto.CurValC = dbo.CurValC;
            dto.CurValN = dbo.CurValN;
            dto.Description = dbo.Description;
            dto.Moddescr = dbo.Moddescr;
            dto.Unit = dbo.Unit;

            return dto;
        }
        public static PlantParam MapToDbo(this ParameterDto dto)
        {
            var dbo = new PlantParam();
            dbo.ParamName = dto.ParamName;
            dbo.PlantType = dto.PlantType;
            dbo.CType = dto.CType;
            dbo.CurValC = dto.CurValC;
            dbo.CurValN = dto.CurValN;
            dbo.Description = dto.Description;
            dbo.Moddescr = dto.Moddescr;
            dbo.Unit = dto.Unit;

            return dbo;
        }
    }
}
