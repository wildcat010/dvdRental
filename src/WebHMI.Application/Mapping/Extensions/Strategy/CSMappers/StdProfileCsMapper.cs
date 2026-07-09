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
        public static void MapEntity(Stdcsprofile entity, StdProfileCsDto dto)
        {

            entity.Activeflag = dto.ActiveFlag;
            entity.Planno = dto.PlanNo;
            entity.Coiltempprofilehead = dto.Coiltempprofilehead;
            entity.Coiltempprofiletail = dto.Coiltempprofiletail;
            entity.Description = dto.Description;
            entity.Lengthprofilehead = dto.Lengthprofilehead;
            entity.Lengthprofileheadwedge = dto.Lengthprofileheadwedge;
            entity.Lengthprofiletail = dto.Lengthprofiletail;
            entity.Lengthprofiletailwedge = dto.Lengthprofiletailwedge;
            entity.Lengthuncooledhead = dto.Lengthuncooledhead;
            entity.Lengthuncooledtail = dto.Lengthuncooledtail;
            entity.Description2 = dto.Description2;

        }

        public static StdProfileCsDto ToDto(Stdcsprofile entity) => new()
        {

            ActiveFlag = entity.Activeflag,
            PlanNo = entity.Planno,
            Coiltempprofilehead = entity.Coiltempprofilehead,
            Coiltempprofiletail = entity.Coiltempprofiletail,
            Description = entity.Description,
            Lengthprofilehead = entity.Lengthprofilehead,
            Lengthprofileheadwedge = entity.Lengthprofileheadwedge,
            Lengthprofiletail = entity.Lengthprofiletail,
            Lengthprofiletailwedge = entity.Lengthprofiletailwedge,
            Lengthuncooledhead = entity.Lengthuncooledhead,
            Lengthuncooledtail = entity.Lengthuncooledtail,
            Description2 = entity.Description2,
        };
    }
}
