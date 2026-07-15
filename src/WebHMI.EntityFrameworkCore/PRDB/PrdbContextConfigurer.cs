using EntityFramework.Exceptions.Oracle;
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
			builder.UseSqlServer(connectionString).EnableSensitiveDataLogging().UseExceptionProcessor();
		}

		public static void Configure(DbContextOptionsBuilder<PrdbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection).EnableSensitiveDataLogging().UseExceptionProcessor();
        }
	}
}
