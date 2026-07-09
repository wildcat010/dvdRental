using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WebHMI.WebHMI
{
	/* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
	public class WebHMIDbContextFactory : IDesignTimeDbContextFactory<WebHMIDbContext>
	{
		//public WebHMIDbContext CreateDbContext(string[] args)
		//{
		//	var builder = new DbContextOptionsBuilder<WebHMIDbContext>();

		//	/*
  //           You can provide an environmentName parameter to the AppConfigurations.Get method. 
  //           In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
  //           Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
  //           https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
  //           */
		//	var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

		//	WebHMIDbContextConfigurer.Configure(builder, configuration.GetConnectionString("Default"));

		//	return new WebHMIDbContext(builder.Options);
		//}

        public WebHMIDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebHMIDbContext>();
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=L2NCTR)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=prdb)));User Id=WEBHMI;Password=a423pa;", b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19));

            return new WebHMIDbContext(optionsBuilder.Options);
        }
    }
}


