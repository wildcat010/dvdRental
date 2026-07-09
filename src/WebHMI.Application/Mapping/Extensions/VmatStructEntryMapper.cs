using WebHMI.Dtos;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal static class VmatStructEntryMapper
	{
		public static MeCodeDto ToOrMeCodeDto(this VMatStructEntry hmiVEntryMatStruct)
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
        public static MeCodeDto ToPhyMeCodeDto(this VMatStructEntry hmiVEntryMatStruct)
        {
            return new MeCodeDto
            {
                MesId = hmiVEntryMatStruct.Enphmesid ?? 0,
                MeId = hmiVEntryMatStruct.Enphmeid,
                MeCreator = hmiVEntryMatStruct.Enphcreator,
                ExtId = hmiVEntryMatStruct.Enphextid,
                MatType = hmiVEntryMatStruct.Enphmetype,
                Status = hmiVEntryMatStruct.Enphstatus ?? 0
            };
        }
    }
}
