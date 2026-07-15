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
        public static void MapEntity(StdDirFmPfcParaPpass entity, StdDirFmPfcParapPassDto dto)
        {
            entity.PlanNo = dto.PlanNo;
            entity.ActiveFlag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.PassNo = dto.PassNo;
            entity.FbUl = dto.Fbul;
            entity.FbLl = dto.Fbll;
            entity.SrUl = dto.Srul;
            entity.SrLl = dto.Srll;
            entity.FacDfbDfr = dto.Facdfbdfr;
            entity.FacDfbDiu = dto.Facdfbdiu;
        }

        public static StdDirFmPfcParapPassDto ToDto(StdDirFmPfcParaPpass entity) => new()
        {
            PlanNo = entity.PlanNo,
            ActiveFlag = entity.ActiveFlag,
            PassNo = entity.PassNo,
            Description = entity.Description,
            Fbul = entity.FbUl,
            Fbll = entity.FbLl,
            Srul = entity.SrUl,
            Srll = entity.SrLl,
            Facdfbdfr = entity.FacDfbDfr,
            Facdfbdiu = entity.FacDfbDiu
        };
    }
}
