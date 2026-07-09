using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Strategy.ApsRef;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public static class ApsRefMapper
    {
        public static Apsref ToEntity(this ApsRefDto dto)
        {
            var result = new Apsref();
            result.MapFromDto(dto);
            return result;
        }

        public static void MapFromDto(this Apsref entity, ApsRefDto dto)
        {
            entity.Keyname = dto.KeyName;
            entity.Keytype = dto.KeyType;
            entity.Apskey = dto.ApsKey;
        }

        public static ApsRefDto MapToDto(this Apsref entity)
        {
            var result = new ApsRefDto();
            result.KeyName = entity.Keyname;
            result.KeyType = entity.Keytype;
            result.ApsKey = entity.Apskey;

            return result;
        }
    }
}
