using System;
using WebHMI.API.Prdb;
using WebHMI.Dtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.API.Helpers
{
    public static class MatStructExtensions
    {
        public static MeCodeDto ToMeCodeDto(this VMatStructEntry hmiVEntryMatStruct)
        {
            return new MeCodeDto
            {
                MesId = hmiVEntryMatStruct.EnOrMesId ?? 0,
                MeId = hmiVEntryMatStruct.EnOrMeId,
                MeCreator = hmiVEntryMatStruct.EnOrCreator,
                ExtId = hmiVEntryMatStruct.EnOrExtId,
                MatType = hmiVEntryMatStruct.EnOrMeType,
                Status = hmiVEntryMatStruct.EnOrStatus ?? 0
            };
        }
    }
}
