using System;
using System.Collections.Generic;

namespace WebHMI.Dtos.Sessions
{
	public class ApplicationInfoDto
	{
		public string Version { get; set; }

		public DateTime ReleaseDate { get; set; }

		public Dictionary<string, bool> Features { get; set; }
        public string RepositoryName { get; set; }
	}
}


