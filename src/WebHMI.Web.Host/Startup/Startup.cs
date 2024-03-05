using System;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Abp.AspNetCore;
using Abp.AspNetCore.Mvc.Antiforgery;
using Abp.Castle.Logging.Log4Net;
using Abp.Extensions;
using WebHMI.Configuration;
using WebHMI.Identity;
using Abp.AspNetCore.SignalR.Hubs;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using WebHMI.Services;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WebHMI.Controllers;

namespace WebHMI.Web.Host.Startup
{
    public class Startup
    {
        private const string _defaultCorsPolicyName = "localhost";

        private const string _apiVersion = "v1";

        private readonly IConfigurationRoot _appConfiguration;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public Startup(IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AbpAutoValidateAntiforgeryTokenAttribute());
            })
			.AddNewtonsoftJson(options =>
			{
				options.SerializerSettings.Converters.Add(new StringEnumConverter());
				options.SerializerSettings.Converters.Add(new TimeSpanConverter());
			});

			IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            services.AddSignalR().AddJsonProtocol(option => { option.PayloadSerializerOptions.NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals; });

			services.AddCors(
				options => options.AddPolicy(
					_defaultCorsPolicyName,
					builder => builder
						.WithOrigins(
							// CorsOrigins in appsettings.json
							_appConfiguration.GetSection("CorsOrigins").Get<string[]>()
						)
						.AllowAnyHeader()
						.AllowAnyMethod()
						.AllowCredentials()
				)
			);

			ConfigureSwagger(services);

			// Configure Abp and Dependency Injection
			services.AddAbpWithoutCreatingServiceProvider<WebHMIWebHostModule>(
				// Configure Log4Net logging
				options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
					f => f.UseAbpLog4Net().WithConfig("log4net.config")
				)
			);
		}

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(options => { options.UseAbpRequestLocalization = false; }); // Initializes ABP framework.

            app.UseCors(_defaultCorsPolicyName);

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAbpRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<AbpCommonHub>("/signalr");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("defaultWithArea", "{area}/{controller=Home}/{action=Index}/{id?}");
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger(c => { c.RouteTemplate = "swagger/{documentName}/swagger.json"; });

            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                // specifying the Swagger JSON endpoint.
                options.SwaggerEndpoint($"/swagger/{_apiVersion}/swagger.json", $"WebHMI API {_apiVersion}");
                options.IndexStream = () => Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("WebHMI.Web.Host.wwwroot.swagger.ui.index.html");
                options.DisplayRequestDuration(); // Controls the display of the request duration (in milliseconds) for "Try it out" requests.
				options.EnableTryItOutByDefault();
			}); // URL: /swagger
        }

        private void ConfigureSwagger(IServiceCollection services)
        {
			services.AddSwaggerGen(options =>
			{
				options.UseOneOfForPolymorphism();
				options.SelectSubTypesUsing(KnownTypeSelector);

				IEnumerable<Type> KnownTypeSelector(Type t)
				{
					if (t.GetCustomAttributes(typeof(KnownTypeAttribute), true) is Attribute[] attributes)
					{
						foreach (var attribute in attributes)
						{
							var knownTypeAttribute = (KnownTypeAttribute)attribute;
							yield return knownTypeAttribute.Type;
						}
					}
				}

				options.SwaggerDoc(_apiVersion, new OpenApiInfo
				{
					Version = _apiVersion,
					Title = "WebHMI API"
				});
				options.DocInclusionPredicate((docName, description) => true);

				//Define the BearerAuth scheme that's in use
				options.AddSecurityDefinition("bearerAuth", new OpenApiSecurityScheme()
				{
					Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
					Name = "Authorization",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.ApiKey,
					Scheme = "Bearer"
				});

				options.OperationFilter<AuthOperationFilter>();

				// Add summaries to swagger
				var hostXmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var hostXmlPath = Path.Combine(AppContext.BaseDirectory, hostXmlFile);
				options.IncludeXmlComments(hostXmlPath);

				string applicationXml = $"{typeof(AccountAppService).Assembly.GetName().Name}.xml";
				var applicationXmlPath = Path.Combine(AppContext.BaseDirectory, applicationXml);
				options.IncludeXmlComments(applicationXmlPath);

				string webCoreXmlFile = $"{typeof(TokenAuthController).Assembly.GetName().Name}.xml";
				var webCoreXmlPath = Path.Combine(AppContext.BaseDirectory, webCoreXmlFile);
				options.IncludeXmlComments(webCoreXmlPath);

				options.SchemaFilter<EnumAsStringSchemaFilter>();

				options.MapType<TimeSpan>(() => new OpenApiSchema { Type = "string", Format = "d.hh:mm:ss.fff", Reference = null, Nullable = false });
				options.MapType<TimeSpan?>(() => new OpenApiSchema { Type = "string", Format = "d.hh:mm:ss.fff", Reference = null, Nullable = true });
			});
		}
    }
}


