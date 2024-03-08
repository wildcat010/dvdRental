using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.PRDB.Dbo
{
	public partial class LogIndex
	{
		[NotMapped]
		public int Level => MapAlarmLevel(Severity);

		private int MapAlarmLevel(short? severity) => severity switch
		{
			163 => 0,
			162 => 1,
			161 => 2,
			_ => 0
		};
	}
}
