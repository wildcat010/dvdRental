using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebHMI.WebHMI
{
	public static class WebHMIDbContextConfigurer
	{
		public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, string connectionString)
		{
			builder.UseOracle(connectionString, b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19));
		}

		public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, DbConnection connection)
		{
			builder.UseOracle(connection, b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19));
        }
	}
}


