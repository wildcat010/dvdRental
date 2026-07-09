using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public class StdCompPlanMapper
    {
        public static void MapEntity(Stdcompplan entity, StdCompPlanDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.TempInd00 = dto.Temp_Ind0;
            entity.TempInd01 = dto.Temp_Ind1;
            entity.TempInd02 = dto.Temp_Ind2;
            entity.TempInd03 = dto.Temp_Ind3;
            entity.TempInd04 = dto.Temp_Ind4;
            entity.TempInd05 = dto.Temp_Ind5;
            entity.TempInd06 = dto.Temp_Ind6;
            entity.TempInd07 = dto.Temp_Ind7;
            entity.TempInd08 = dto.Temp_Ind8;
            entity.TempInd09 = dto.Temp_Ind9;
            entity.TempInd10 = dto.Temp_Ind10;
            entity.TempInd11 = dto.Temp_Ind11;
            entity.TempInd12 = dto.Temp_Ind12;
            entity.TempInd13 = dto.Temp_Ind13;
            entity.TempInd14 = dto.Temp_Ind14;
            entity.TempInd15 = dto.Temp_Ind15;
            entity.TempInd16 = dto.Temp_Ind16;
            entity.TempInd17 = dto.Temp_Ind17;
            entity.TempInd18 = dto.Temp_Ind18;
            entity.TempInd19 = dto.Temp_Ind19;
            entity.TempInd20 = dto.Temp_Ind20;
            entity.TempInd21 = dto.Temp_Ind21;
            entity.TempInd22 = dto.Temp_Ind22;
            entity.TempInd23 = dto.Temp_Ind23;
            entity.TempInd24 = dto.Temp_Ind24;
            entity.TempInd25 = dto.Temp_Ind25;

            entity.KawaInd00 = dto.Kawa_Ind0;
            entity.KawaInd01 = dto.Kawa_Ind1;
            entity.KawaInd02 = dto.Kawa_Ind2;
            entity.KawaInd03 = dto.Kawa_Ind3;
            entity.KawaInd04 = dto.Kawa_Ind4;
            entity.KawaInd05 = dto.Kawa_Ind5;
            entity.KawaInd06 = dto.Kawa_Ind6;
            entity.KawaInd07 = dto.Kawa_Ind7;
            entity.KawaInd08 = dto.Kawa_Ind8;
            entity.KawaInd09 = dto.Kawa_Ind9;
            entity.KawaInd10 = dto.Kawa_Ind10;
            entity.KawaInd11 = dto.Kawa_Ind11;
            entity.KawaInd12 = dto.Kawa_Ind12;
            entity.KawaInd13 = dto.Kawa_Ind13;
            entity.KawaInd14 = dto.Kawa_Ind14;
            entity.KawaInd15 = dto.Kawa_Ind15;
            entity.KawaInd16 = dto.Kawa_Ind16;
            entity.KawaInd17 = dto.Kawa_Ind17;
            entity.KawaInd18 = dto.Kawa_Ind18;
            entity.KawaInd19 = dto.Kawa_Ind19;
            entity.KawaInd20 = dto.Kawa_Ind20;
            entity.KawaInd21 = dto.Kawa_Ind21;
            entity.KawaInd22 = dto.Kawa_Ind22;
            entity.KawaInd23 = dto.Kawa_Ind23;
            entity.KawaInd24 = dto.Kawa_Ind24;
            entity.KawaInd25 = dto.Kawa_Ind25;
        }

        public static StdCompPlanDto ToDto(Stdcompplan entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            Temp_Ind0 = entity.TempInd00,
            Temp_Ind1 = entity.TempInd01,
            Temp_Ind2 = entity.TempInd02,
            Temp_Ind3 = entity.TempInd03,
            Temp_Ind4 = entity.TempInd04,
            Temp_Ind5 = entity.TempInd05,
            Temp_Ind6 = entity.TempInd06,
            Temp_Ind7 = entity.TempInd07,
            Temp_Ind8 = entity.TempInd08,
            Temp_Ind9 = entity.TempInd09,
            Temp_Ind10 = entity.TempInd10,
            Temp_Ind11 = entity.TempInd11,
            Temp_Ind12 = entity.TempInd12,
            Temp_Ind13 = entity.TempInd13,
            Temp_Ind14 = entity.TempInd14,
            Temp_Ind15 = entity.TempInd15,
            Temp_Ind16 = entity.TempInd16,
            Temp_Ind17 = entity.TempInd17,
            Temp_Ind18 = entity.TempInd18,
            Temp_Ind19 = entity.TempInd19,
            Temp_Ind20 = entity.TempInd20,
            Temp_Ind21 = entity.TempInd21,
            Temp_Ind22 = entity.TempInd22,
            Temp_Ind23 = entity.TempInd23,
            Temp_Ind24 = entity.TempInd24,
            Temp_Ind25 = entity.TempInd25,

            Kawa_Ind0 = entity.KawaInd00,
            Kawa_Ind1 = entity.KawaInd01,
            Kawa_Ind2 = entity.KawaInd02,
            Kawa_Ind3 = entity.KawaInd03,
            Kawa_Ind4 = entity.KawaInd04,
            Kawa_Ind5 = entity.KawaInd05,
            Kawa_Ind6 = entity.KawaInd06,
            Kawa_Ind7 = entity.KawaInd07,
            Kawa_Ind8 = entity.KawaInd08,
            Kawa_Ind9 = entity.KawaInd09,
            Kawa_Ind10 = entity.KawaInd10,
            Kawa_Ind11 = entity.KawaInd11,
            Kawa_Ind12 = entity.KawaInd12,
            Kawa_Ind13 = entity.KawaInd13,
            Kawa_Ind14 = entity.KawaInd14,
            Kawa_Ind15 = entity.KawaInd15,
            Kawa_Ind16 = entity.KawaInd16,
            Kawa_Ind17 = entity.KawaInd17,
            Kawa_Ind18 = entity.KawaInd18,
            Kawa_Ind19 = entity.KawaInd19,
            Kawa_Ind20 = entity.KawaInd20,
            Kawa_Ind21 = entity.KawaInd21,
            Kawa_Ind22 = entity.KawaInd22,
            Kawa_Ind23 = entity.KawaInd23,
            Kawa_Ind24 = entity.KawaInd24,
            Kawa_Ind25 = entity.KawaInd25

        };
    }
}
