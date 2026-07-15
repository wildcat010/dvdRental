using System.Data.Common;
using EntityFramework.Exceptions.Oracle;
using Microsoft.EntityFrameworkCore;

namespace WebHMI.WebHMI
{
	public static class WebHMIDbContextConfigurer
	{
		public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, string connectionString)
		{
			builder.UseSqlServer(connectionString).UseExceptionProcessor();
		}

		public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, DbConnection connection)
		{
			builder.UseSqlServer(connection).UseExceptionProcessor();
        }
	}
}


