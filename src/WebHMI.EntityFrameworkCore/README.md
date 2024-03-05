# Create WebHMI database migration
Go to `API.Core\src` directory, replace `MigrationName` with your name and run this command
`dotnet ef migrations add MigrationName --project WebHMI.EntityFrameworkCore --startup-project WebHMI.Web.Host --context WebHMI.WebHMI.WebHMIDbContext --output-dir WebHMI\Migrations`

# Update database
Go to `API.Core\src`
`dotnet ef database update --project WebHMI.EntityFrameworkCore --startup-project WebHMI.Web.Host --context WebHMI.WebHMI.WebHMIDbContext`

# Migrate WebHMI database
Provide connection string in `appsettings.json` file, run `Migrator` project and follow instructions.

# Troubleshooting
- `EntityFrameworkCore` and `Migrator` modules may have dependencies on other projects that are not being met
- use `Debugger.Launch()` to debug command line tools