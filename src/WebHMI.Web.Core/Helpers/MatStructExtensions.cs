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
                MesId = hmiVEntryMatStruct.Enormesid ?? 0,
                MeId = hmiVEntryMatStruct.Enormeid,
                MeCreator = hmiVEntryMatStruct.Enorcreator,
                ExtId = hmiVEntryMatStruct.Enorextid,
                MatType = hmiVEntryMatStruct.Enormetype,
                Status = hmiVEntryMatStruct.Enorstatus ?? 0
            };
        }
    }
}
