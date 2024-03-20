using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos.Common;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Mapping.Extensions
{
	internal static class MaterialHeaderDtoMapper
	{
        public static MaterialHeaderDto MapData(this MaterialHeaderDto result, List<HmiVMatInfoShort> matInfo)
		{
			var sourceM = matInfo.FirstOrDefault(x => x.EdOrSrc == "M");
			var sourceE = matInfo.FirstOrDefault(x => x.EdOrSrc == "E");
			var sourceL = matInfo.FirstOrDefault(x => x.EdOrSrc == "L");
			var sourceS = matInfo.FirstOrDefault(x => x.EdOrSrc == "S");

			// TODO: add dto & mapping

            return result;
		}

		public static MaterialHeaderDto MapEffectiveData(this MaterialHeaderDto result, HmiVMatInfoShort matInfo)
		{
			// TODO: add dto & mapping

			return result;
		}
	}
}
