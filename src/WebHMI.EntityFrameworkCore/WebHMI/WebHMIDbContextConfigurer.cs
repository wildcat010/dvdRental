using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebHMI.WebHMI
{
	public static class WebHMIDbContextConfigurer
	{
		public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, string connectionString)
		{
			builder.UseOracle(connectionString);
		}

		public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, DbConnection connection)
		{
			builder.UseOracle(connection);
		}
	}
}


