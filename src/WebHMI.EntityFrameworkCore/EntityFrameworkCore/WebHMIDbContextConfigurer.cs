using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebHMI.EntityFrameworkCore
{
    public static class WebHMIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebHMIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}


