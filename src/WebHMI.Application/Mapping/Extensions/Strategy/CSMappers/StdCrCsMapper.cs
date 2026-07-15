using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdCrCsMapper
    {
        public static void MapEntity(StdCsCr entity, StdCrCsDto dto)
        {
            entity.ActiveFlag = dto.ActiveFlag;
            entity.PlanNo = dto.PlanNo;
            entity.CrsInd10 = dto.CrsInd10;
            entity.CrsInd11 = dto.CrsInd11;
            entity.CrsInd12 = dto.CrsInd12;
            entity.CrsInd13 = dto.CrsInd13;
            entity.CrsInd14 = dto.CrsInd14;
            entity.CrsInd15 = dto.CrsInd15;
            entity.CrsInd16 = dto.CrsInd16;
            entity.CrsInd17 = dto.CrsInd17;
            entity.CrsInd18 = dto.CrsInd18;
            entity.CrsInd19 = dto.CrsInd19;
            entity.CrsInd20 = dto.CrsInd20;
            entity.CrsInd21 = dto.CrsInd21;
            entity.CrsInd22 = dto.CrsInd22;
            entity.CrsInd23 = dto.CrsInd23;
            entity.CrsInd24 = dto.CrsInd24;
            entity.CrsInd25 = dto.CrsInd25;
            entity.CrsInd26 = dto.CrsInd26;
            entity.CrsInd27 = dto.CrsInd27;
            entity.CrsInd28 = dto.CrsInd28;
            entity.CrsInd29 = dto.CrsInd29;
            entity.CrsInd30 = dto.CrsInd30;
            entity.CrsInd31 = dto.CrsInd31;
            entity.CrsInd32 = dto.CrsInd32;
            entity.CrsInd33 = dto.CrsInd33;
            entity.CrsInd34 = dto.CrsInd34;
            entity.CrsInd35 = dto.CrsInd35;
            entity.CrsInd36 = dto.CrsInd36;
            entity.CrsInd37 = dto.CrsInd37;
            entity.CrsInd38 = dto.CrsInd38;
            entity.CrsInd39 = dto.CrsInd39;
            entity.Delaylength = dto.Delaylength;
            entity.Description = dto.Description;
            entity.CrsInd00 = dto.CrsInd00;
            entity.CrsInd01 = dto.CrsInd01;
            entity.CrsInd02 = dto.CrsInd02;
            entity.CrsInd03 = dto.CrsInd03;
            entity.CrsInd04 = dto.CrsInd04;
            entity.CrsInd05 = dto.CrsInd05;
            entity.CrsInd06 = dto.CrsInd06;
            entity.CrsInd07 = dto.CrsInd07;
            entity.CrsInd08 = dto.CrsInd08;
            entity.CrsInd09 = dto.CrsInd09;
        }

        public static StdCrCsDto ToDto(StdCsCr entity) => new()
        {
            ActiveFlag = entity.ActiveFlag,
            PlanNo = entity.PlanNo,
            CrsInd10 = entity.CrsInd10,
            CrsInd11 = entity.CrsInd11,
            CrsInd12 = entity.CrsInd12,
            CrsInd13 = entity.CrsInd13,
            CrsInd14 = entity.CrsInd14,
            CrsInd15 = entity.CrsInd15,
            CrsInd16 = entity.CrsInd16,
            CrsInd17 = entity.CrsInd17,
            CrsInd18 = entity.CrsInd18,
            CrsInd19 = entity.CrsInd19,
            CrsInd20 = entity.CrsInd20,
            CrsInd21 = entity.CrsInd21,
            CrsInd22 = entity.CrsInd22,
            CrsInd23 = entity.CrsInd23,
            CrsInd24 = entity.CrsInd24,
            CrsInd25 = entity.CrsInd25,
            CrsInd26 = entity.CrsInd26,
            CrsInd27 = entity.CrsInd27,
            CrsInd28 = entity.CrsInd28,
            CrsInd29 = entity.CrsInd29,
            CrsInd30 = entity.CrsInd30,
            CrsInd31 = entity.CrsInd31,
            CrsInd32 = entity.CrsInd32,
            CrsInd33 = entity.CrsInd33,
            CrsInd34 = entity.CrsInd34,
            CrsInd35 = entity.CrsInd35,
            CrsInd36 = entity.CrsInd36,
            CrsInd37 = entity.CrsInd37,
            CrsInd38 = entity.CrsInd38,
            CrsInd39 = entity.CrsInd39,
            Delaylength = entity.Delaylength,
            Description = entity.Description,
            CrsInd00 = entity.CrsInd00,
            CrsInd01 = entity.CrsInd01,
            CrsInd02 = entity.CrsInd02,
            CrsInd03 = entity.CrsInd03,
            CrsInd04 = entity.CrsInd04,
            CrsInd05 = entity.CrsInd05,
            CrsInd06 = entity.CrsInd06,
            CrsInd07 = entity.CrsInd07,
            CrsInd08 = entity.CrsInd08,
            CrsInd09 = entity.CrsInd09,
        };
    }
}

