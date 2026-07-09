
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    internal class StdcsedgemaskingMapper
    {
        internal static void MapEntity(Stdcsedgemasking entity, StdcsedgemaskingDto dto)
        {
            entity.Planno = dto.PlanNo;
            entity.Activeflag = dto.ActiveFlag;
            entity.Description = dto.Description;
            entity.Description2 = dto.Comment;
            entity.EdgemaskingwidthInd00 = dto.Valve1To10;
            entity.EdgemaskingwidthInd01 = dto.Valve11To20;
            entity.EdgemaskingwidthInd02 = dto.Valve21To30;
            entity.EdgemaskingwidthInd03 = dto.Valve31To38;
            entity.EdgemaskingwidthInd04 = dto.Valve39To46;
            entity.EdgemaskingwidthInd05 = dto.Valve47To54;
            entity.EdgemaskingwidthInd06 = dto.Valve55To62;
            entity.EdgemaskingwidthInd07 = dto.Valve63To70;
            entity.EdgemaskingwidthInd08 = dto.Valve71To78;
            entity.EdgemaskingwidthInd09 = dto.Valve79To86;
            entity.EdgemaskingwidthInd10 = dto.Valve87To94;
            entity.EdgemaskingwidthInd11 = dto.Valve95To102;

        }

        internal static StdcsedgemaskingDto ToDto(Stdcsedgemasking entity) => new()
        {
            PlanNo = entity.Planno,
            ActiveFlag = entity.Activeflag,
            Description = entity.Description,
            Comment = entity.Description2,
            Valve1To10 = entity.EdgemaskingwidthInd00,
            Valve11To20 = entity.EdgemaskingwidthInd01,
            Valve21To30 = entity.EdgemaskingwidthInd02,
            Valve31To38 = entity.EdgemaskingwidthInd03,
            Valve39To46 = entity.EdgemaskingwidthInd04,
            Valve47To54 = entity.EdgemaskingwidthInd05,
            Valve55To62 = entity.EdgemaskingwidthInd06,
            Valve63To70 = entity.EdgemaskingwidthInd07,
            Valve71To78 = entity.EdgemaskingwidthInd08,
            Valve79To86 = entity.EdgemaskingwidthInd09,
            Valve87To94 = entity.EdgemaskingwidthInd10,
            Valve95To102 = entity.EdgemaskingwidthInd11,
        };
    }
}
