using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy.CSMappers
{
    public static class StdProfileCsMapper
    {
        public static void MapEntity(StdCsProfile entity, StdProfileCsDto dto)
        {

            entity.ActiveFlag = dto.ActiveFlag;
            entity.PlanNo = dto.PlanNo;
            entity.CoilTempProfileHead = dto.Coiltempprofilehead;
            entity.CoilTempProfileTail = dto.Coiltempprofiletail;
            entity.Description = dto.Description;
            entity.LengthProfileHead = dto.Lengthprofilehead;
            entity.LengthProfileHeadWedge = dto.Lengthprofileheadwedge;
            entity.LengthProfileTail = dto.Lengthprofiletail;
            entity.LengthProfileTailWedge = dto.Lengthprofiletailwedge;
            entity.LengthUncooledHead = dto.Lengthuncooledhead;
            entity.LengthUncooledTail = dto.Lengthuncooledtail;
            entity.Description2 = dto.Description2;

        }

        public static StdProfileCsDto ToDto(StdCsProfile entity) => new()
        {

            ActiveFlag = entity.ActiveFlag,
            PlanNo = entity.PlanNo,
            Coiltempprofilehead = entity.CoilTempProfileHead,
            Coiltempprofiletail = entity.CoilTempProfileTail,
            Description = entity.Description,
            Lengthprofilehead = entity.LengthProfileHead,
            Lengthprofileheadwedge = entity.LengthProfileHeadWedge,
            Lengthprofiletail = entity.LengthProfileTail,
            Lengthprofiletailwedge = entity.LengthProfileTailWedge,
            Lengthuncooledhead = entity.LengthUncooledHead,
            Lengthuncooledtail = entity.LengthUncooledTail,
            Description2 = entity.Description2,
        };
    }
}
