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
              MesId = hmiVEntryMatStruct.EnOrMesId ?? 0,
                MeId = hmiVEntryMatStruct.EnOrMeId,
                MeCreator = hmiVEntryMatStruct.EnOrCreator,
                ExtId = hmiVEntryMatStruct.EnOrExtId,
                MatType = hmiVEntryMatStruct.EnOrMeType,
                Status = hmiVEntryMatStruct.EnOrStatus ?? 0
			};
        }
        public static MeCodeDto ToPhyMeCodeDto(this VMatStructEntry hmiVEntryMatStruct)
        {
            return new MeCodeDto
            {
                MesId = hmiVEntryMatStruct.EnPhMesId ?? 0,
                MeId = hmiVEntryMatStruct.EnPhMeId,
                MeCreator = hmiVEntryMatStruct.EnPhCreator,
                ExtId = hmiVEntryMatStruct.EnPhExtId,
                MatType = hmiVEntryMatStruct.EnPhMeType,
                Status = hmiVEntryMatStruct.EnPhStatus ?? 0
            };
        }
    }
}
