using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;
using WebHMI.PRDB;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal static class VmatStructEntryMapper
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
