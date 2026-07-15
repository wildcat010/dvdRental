using WebHMI.Dtos.Strategy.ApsRef;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions.Strategy
{
    public static class ApsRefMapper
    {
        public static ApsRef ToEntity(this ApsRefDto dto)
        {
            var result = new ApsRef();
            result.MapFromDto(dto);
            return result;
        }

        public static void MapFromDto(this ApsRef entity, ApsRefDto dto)
        {
            entity.KeyName = dto.KeyName;
            entity.KeyType = dto.KeyType;
            entity.ApsKey = dto.ApsKey;
        }

        public static ApsRefDto MapToDto(this ApsRef entity)
        {
            var result = new ApsRefDto();
            result.KeyName = entity.KeyName;
            result.KeyType = entity.KeyType;
            result.ApsKey = entity.ApsKey;

            return result;
        }
    }
}
