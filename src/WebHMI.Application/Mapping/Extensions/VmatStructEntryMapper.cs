using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.PRDB;

namespace WebHMI.Mapping.Extensions
{
	internal static class VmatStructEntryMapper
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
