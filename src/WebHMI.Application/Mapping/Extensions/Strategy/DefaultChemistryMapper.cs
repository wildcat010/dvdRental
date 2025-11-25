using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.DefaultChemistry;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public static class DefaultChemistryMapper
    {
        public static void MapEntity(MatDat entity, DefaultChemistryDto dto)
        {
            entity.AlloyCode = dto.Alloycode;

            entity.CnInd0 = dto.Cn_Ind0;
            entity.CnInd1 = dto.Cn_Ind1;
            entity.CnInd2 = dto.Cn_Ind2;
            entity.CnInd3 = dto.Cn_Ind3;
            entity.CnInd4 = dto.Cn_Ind4;
            entity.CnInd5 = dto.Cn_Ind5;
            entity.CnInd6 = dto.Cn_Ind6;
            entity.CnInd7 = dto.Cn_Ind7;
            entity.CnInd8 = dto.Cn_Ind8;
            entity.CnInd9 = dto.Cn_Ind9;
            entity.CnInd10 = dto.Cn_Ind10;
            entity.CnInd11 = dto.Cn_Ind11;
            entity.CnInd12 = dto.Cn_Ind12;
            entity.CnInd13 = dto.Cn_Ind13;
            entity.CnInd14 = dto.Cn_Ind14;
            entity.CnInd15 = dto.Cn_Ind15;
            entity.CnInd16 = dto.Cn_Ind16;
            entity.CnInd17 = dto.Cn_Ind17;
            entity.CnInd18 = dto.Cn_Ind18;
            entity.CnInd19 = dto.Cn_Ind19;
            entity.CnInd20 = dto.Cn_Ind20;
            entity.CnInd21 = dto.Cn_Ind21;
            entity.CnInd22 = dto.Cn_Ind22;
            entity.CnInd23 = dto.Cn_Ind23;
            entity.CnInd24 = dto.Cn_Ind24;
            entity.CnInd25 = dto.Cn_Ind25;
            entity.CnInd26 = dto.Cn_Ind26;
            entity.CnInd27 = dto.Cn_Ind27;
            entity.CnInd28 = dto.Cn_Ind28;
            entity.CnInd29 = dto.Cn_Ind29;
            entity.CnInd30 = dto.Cn_Ind30;
            entity.CnInd31 = dto.Cn_Ind31;
            entity.CnInd32 = dto.Cn_Ind32;
            entity.CnInd33 = dto.Cn_Ind33;
            entity.CnInd34 = dto.Cn_Ind34;
            entity.CnInd35 = dto.Cn_Ind35;
            entity.CnInd36 = dto.Cn_Ind36;
            entity.CnInd37 = dto.Cn_Ind37;
            entity.CnInd38 = dto.Cn_Ind38;
            entity.CnInd39 = dto.Cn_Ind39;

            entity.CaInd0 = dto.Ca_Ind0;
            entity.CaInd1 = dto.Ca_Ind1;
            entity.CaInd2 = dto.Ca_Ind2;
            entity.CaInd3 = dto.Ca_Ind3;
            entity.CaInd4 = dto.Ca_Ind4;
            entity.CaInd5 = dto.Ca_Ind5;
            entity.CaInd6 = dto.Ca_Ind6;
            entity.CaInd7 = dto.Ca_Ind7;
            entity.CaInd8 = dto.Ca_Ind8;
            entity.CaInd9 = dto.Ca_Ind9;
            entity.CaInd10 = dto.Ca_Ind10;
            entity.CaInd11 = dto.Ca_Ind11;
            entity.CaInd12 = dto.Ca_Ind12;
            entity.CaInd13 = dto.Ca_Ind13;
            entity.CaInd14 = dto.Ca_Ind14;
            entity.CaInd15 = dto.Ca_Ind15;
            entity.CaInd16 = dto.Ca_Ind16;
            entity.CaInd17 = dto.Ca_Ind17;
            entity.CaInd18 = dto.Ca_Ind18;
            entity.CaInd19 = dto.Ca_Ind19;
            entity.CaInd20 = dto.Ca_Ind20;
            entity.CaInd21 = dto.Ca_Ind21;
            entity.CaInd22 = dto.Ca_Ind22;
            entity.CaInd23 = dto.Ca_Ind23;
            entity.CaInd24 = dto.Ca_Ind24;
            entity.CaInd25 = dto.Ca_Ind25;
            entity.CaInd26 = dto.Ca_Ind26;
            entity.CaInd27 = dto.Ca_Ind27;
            entity.CaInd28 = dto.Ca_Ind28;
            entity.CaInd29 = dto.Ca_Ind29;
            entity.CaInd30 = dto.Ca_Ind30;
            entity.CaInd31 = dto.Ca_Ind31;
            entity.CaInd32 = dto.Ca_Ind32;
            entity.CaInd33 = dto.Ca_Ind33;
            entity.CaInd34 = dto.Ca_Ind34;
            entity.CaInd35 = dto.Ca_Ind35;
            entity.CaInd36 = dto.Ca_Ind36;
            entity.CaInd37 = dto.Ca_Ind37;
            entity.CaInd38 = dto.Ca_Ind38;
            entity.CaInd39 = dto.Ca_Ind39;
        }

        public static DefaultChemistryDto ToDto(MatDat entity) => new()
        {
            Alloycode = entity.AlloyCode,

            Cn_Ind0 = entity.CnInd0,
            Cn_Ind1 = entity.CnInd1,
            Cn_Ind2 = entity.CnInd2,
            Cn_Ind3 = entity.CnInd3,
            Cn_Ind4 = entity.CnInd4,
            Cn_Ind5 = entity.CnInd5,
            Cn_Ind6 = entity.CnInd6,
            Cn_Ind7 = entity.CnInd7,
            Cn_Ind8 = entity.CnInd8,
            Cn_Ind9 = entity.CnInd9,
            Cn_Ind10 = entity.CnInd10,
            Cn_Ind11 = entity.CnInd11,
            Cn_Ind12 = entity.CnInd12,
            Cn_Ind13 = entity.CnInd13,
            Cn_Ind14 = entity.CnInd14,
            Cn_Ind15 = entity.CnInd15,
            Cn_Ind16 = entity.CnInd16,
            Cn_Ind17 = entity.CnInd17,
            Cn_Ind18 = entity.CnInd18,
            Cn_Ind19 = entity.CnInd19,
            Cn_Ind20 = entity.CnInd20,
            Cn_Ind21 = entity.CnInd21,
            Cn_Ind22 = entity.CnInd22,
            Cn_Ind23 = entity.CnInd23,
            Cn_Ind24 = entity.CnInd24,
            Cn_Ind25 = entity.CnInd25,
            Cn_Ind26 = entity.CnInd26,
            Cn_Ind27 = entity.CnInd27,
            Cn_Ind28 = entity.CnInd28,
            Cn_Ind29 = entity.CnInd29,
            Cn_Ind30 = entity.CnInd30,
            Cn_Ind31 = entity.CnInd31,
            Cn_Ind32 = entity.CnInd32,
            Cn_Ind33 = entity.CnInd33,
            Cn_Ind34 = entity.CnInd34,
            Cn_Ind35 = entity.CnInd35,
            Cn_Ind36 = entity.CnInd36,
            Cn_Ind37 = entity.CnInd37,
            Cn_Ind38 = entity.CnInd38,
            Cn_Ind39 = entity.CnInd39,

            Ca_Ind0 = entity.CaInd0,
            Ca_Ind1 = entity.CaInd1,
            Ca_Ind2 = entity.CaInd2,
            Ca_Ind3 = entity.CaInd3,
            Ca_Ind4 = entity.CaInd4,
            Ca_Ind5 = entity.CaInd5,
            Ca_Ind6 = entity.CaInd6,
            Ca_Ind7 = entity.CaInd7,
            Ca_Ind8 = entity.CaInd8,
            Ca_Ind9 = entity.CaInd9,
            Ca_Ind10 = entity.CaInd10,
            Ca_Ind11 = entity.CaInd11,
            Ca_Ind12 = entity.CaInd12,
            Ca_Ind13 = entity.CaInd13,
            Ca_Ind14 = entity.CaInd14,
            Ca_Ind15 = entity.CaInd15,
            Ca_Ind16 = entity.CaInd16,
            Ca_Ind17 = entity.CaInd17,
            Ca_Ind18 = entity.CaInd18,
            Ca_Ind19 = entity.CaInd19,
            Ca_Ind20 = entity.CaInd20,
            Ca_Ind21 = entity.CaInd21,
            Ca_Ind22 = entity.CaInd22,
            Ca_Ind23 = entity.CaInd23,
            Ca_Ind24 = entity.CaInd24,
            Ca_Ind25 = entity.CaInd25,
            Ca_Ind26 = entity.CaInd26,
            Ca_Ind27 = entity.CaInd27,
            Ca_Ind28 = entity.CaInd28,
            Ca_Ind29 = entity.CaInd29,
            Ca_Ind30 = entity.CaInd30,
            Ca_Ind31 = entity.CaInd31,
            Ca_Ind32 = entity.CaInd32,
            Ca_Ind33 = entity.CaInd33,
            Ca_Ind34 = entity.CaInd34,
            Ca_Ind35 = entity.CaInd35,
            Ca_Ind36 = entity.CaInd36,
            Ca_Ind37 = entity.CaInd37,
            Ca_Ind38 = entity.CaInd38,
            Ca_Ind39 = entity.CaInd39
        };
    }
}
