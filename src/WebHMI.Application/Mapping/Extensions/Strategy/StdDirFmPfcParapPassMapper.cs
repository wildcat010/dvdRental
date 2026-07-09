using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdDirFmPfcParapPassMapper
    {
        public static void MapEntity(Stddirfmpfcparappass entity, StdDirFmPfcParapPassDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Passno = dto.PassNo;
            entity.Fbul = dto.Fbul;
            entity.Fbll = dto.Fbll;
            entity.Srul = dto.Srul;
            entity.Srll = dto.Srll;
            entity.Facdfbdfr = dto.Facdfbdfr;
            entity.Facdfbdiu = dto.Facdfbdiu;
        }

        public static StdDirFmPfcParapPassDto ToDto(Stddirfmpfcparappass entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            PassNo = entity.Passno,
            Description = entity.Description,
            Fbul = entity.Fbul,
            Fbll = entity.Fbll,
            Srul = entity.Srul,
            Srll = entity.Srll,
            Facdfbdfr = entity.Facdfbdfr,
            Facdfbdiu = entity.Facdfbdiu
        };
    }
}
