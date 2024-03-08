# ABP documentation

Wtart with https://aspnetboilerplate.com/Pages/Documents/Introduction for more information about ABP framework.

In addition to the following instructions below, you have to familiarize yourself with:
- https://aspnetboilerplate.com/Pages/Documents/NLayer-Architecture
- https://aspnetboilerplate.com/Pages/Documents/Module-System
- https://aspnetboilerplate.com/Pages/Documents/Startup-Configuration
- https://aspnetboilerplate.com/Pages/Documents/Dependency-Injection
- https://aspnetboilerplate.com/Pages/Documents/Caching
- https://aspnetboilerplate.com/Pages/Documents/Domain-Services
- https://aspnetboilerplate.com/Pages/Documents/Unit-Of-Work
- https://aspnetboilerplate.com/Pages/Documents/EventBus-Domain-Events
- https://aspnetboilerplate.com/Pages/Documents/Background-Jobs-And-Workers#background-workers
- https://aspnetboilerplate.com/Pages/Documents/SignalR-AspNetCore-Integration


# Application services

Read documents:
- https://aspnetboilerplate.com/Pages/Documents/Application-Services
- https://aspnetboilerplate.com/Pages/Documents/Data-Transfer-Objects
- https://aspnetboilerplate.com/Pages/Documents/Authorization
- https://aspnetboilerplate.com/Pages/Documents/Zero/Permission-Management

Use `...AppService` names for application services, because files like `service-proxy` are generated using this naming convention.

## Exceptions
You don't have to create `try catch` statements, because ABP handles them automatically (logs and parses message in HTTP requests).

You can return status codes:
- 500 Internal server error - `UserFriendlyException`
- 404 Not found - `EntityNotFoundException`

## Filtering
DTO property names should be equal to DBO column names, for easier filtering.
Otherwise, you need to use the database column names.

## Mapping
Extension mapping is used instead of the built-in AutoMapper integration because of:
- database first approach with frequent db changes (strongly typed mapping catches errors during compilation, not runtime)
- easier debugging
- more complex mapping scenarios

## Auditing
Read https://aspnetboilerplate.com/Pages/Documents/Audit-Logging.

By default, ABP audits all endpoint calls, but this behavior is changed.
Auditing can be enabled for individual endpoints using `AuditedAttribute`, and some properties can be ignored using `DisableAuditingAttribute`.

```csharp
	[Audited]
	public LoginDto Get(int id)
	{
		// ...
		return dto;
	}

	class LoginDto
	{
		public string Userame { get; set; }

		[DisableAuditing]
		public string Password { get; set; }
	}
```
# Databases

## Create WebHMI database migration
Go to `API.Core\src` directory, replace `MigrationName` with your name and run this command.  
`dotnet ef migrations add MigrationName --project WebHMI.EntityFrameworkCore --startup-project WebHMI.Web.Host --context WebHMI.WebHMI.WebHMIDbContext --output-dir WebHMI\Migrations`

## Update database
Go to `API.Core\src` and run  
`dotnet ef database update --project WebHMI.EntityFrameworkCore --startup-project WebHMI.Web.Host --context WebHMI.WebHMI.WebHMIDbContext`

## Migrate WebHMI database
Provide connection string in `appsettings.json` EF Core's project, run `Migrator` project and follow instructions.

## DbContext and Repositories

Read https://aspnetboilerplate.com/Pages/Documents/Entity-Framework-Core.

Using repositories is too labor-intensive because they require PK, which is a column named `Id` and of type `int`, which databases do not have.
For this reason, `DbContext` classes are used for direct operations on the database.


```csharp
	public class TestService
	{
		private readonly IDbContextProvider<PrdbContext> _prdbContextProvider;

		public TestAppService(IDbContextProvider<PrdbContext> prdbContextProvider)
		{
			_prdbContextProvider = prdbContextProvider;
		}

		public Entity Get(int id)
		{
			var context = await _prdbContextProvider.GetDbContextAsync();
			return await context.TableName.FirstOrDefaultAsync(record);
		}
	}
```

> Important! Don't dispose `DbContext` because it is still used later, after exiting scope of the method above.

## Troubleshooting
- `EntityFrameworkCore` and `Migrator` modules may have dependencies on other projects that are not being met
- use `Debugger.Launch()` in code to debug command line tools

# Logging

Read https://aspnetboilerplate.com/Pages/Documents/Logging.

- `Castle.Core.Logging` must be used.  
- Logger can be injected in 2 ways:

```csharp
using Castle.Core.Logging; // Import Logging namespace

public class TaskAppService
{    
    // Getting a logger using property injection
    public ILogger Logger { get; set; }

    public void CreateTask(CreateTaskInput input)
    {
        // ...
        Logger.Info("Creating a new task with description: " + input.Description);
    }
}
```

```csharp
using Castle.Core.Logging; // Import Logging namespace

public class TaskAppService
{    
    private readonly ILogger _logger

    // Getting a logger using constructor injection
		TaskAppService(ILogger logger)
		{
			_logger = logger;
		}

    public void CreateTask(CreateTaskInput input)
    {
        // ...
        _logger.Info("Creating a new task with description: " + input.Description);
    }
}
```