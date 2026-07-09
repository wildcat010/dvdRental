using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHMI.PRDB
{
	public class PrdbContextConfigurer
	{
		public static void Configure(DbContextOptionsBuilder<PrdbContext> builder, string connectionString)
		{
			builder.UseOracle(connectionString, b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19)).EnableSensitiveDataLogging();
		}

		public static void Configure(DbContextOptionsBuilder<PrdbContext> builder, DbConnection connection)
		{
			builder.UseOracle(connection, b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19)).EnableSensitiveDataLogging();
		}
	}
}
