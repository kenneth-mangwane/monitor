using log4net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OBS.Core.Interfaces;
using OBS.Core.Interfaces.Bursar;
using OBS.Core.Interfaces.Customers;
using OBS.Core.Interfaces.DAL;
using OBS.Core.Interfaces.Finance;
using OBS.Core.Interfaces.IdentityFramework;
using OBS.Core.Interfaces.Leases;
using OBS.Core.Interfaces.Locations;
using OBS.Core.Interfaces.Residential.Pricing;
using OBS.Core.Interfaces.Student;
using OBS.Core.Logic;
using OBS.Core.Logic.Customer;
using OBS.Core.Logic.DAL;
using OBS.Core.Logic.Finance;
using OBS.Core.Logic.Leases;
using OBS.Core.Logic.Locations;
using OBS.Core.Logic.Residential;
using OBS.Core.Logic.Residential.Pricing;
using OBS.Core.Logic.Student;
using OBS.Database;
using OBS.Database.Models;
using OBS.Database.Oracle;
using SouthPointMaintenance.Data;
using SP.Core.Users;
using SobsConfiguration;
using static SP.Configuration.Constants;
using OBS.Core.Interfaces.Residential;
using OBS.Core;
using OBS.Core.Interfaces.Biometric;
using OBS.Core.Logic.Biometric;
using SP.Utilities.Services;
using SouhtPoint.Services;
using OBS.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.IO;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Swashbuckle.AspNetCore.Filters;
using OBS.API.Swagger;
using System.Linq;
using OBS.Core.Interfaces.CityManagerLogic;
using OBS.Core.Interfaces.BuildingManagerLogic;
using OBS.Core.Interfaces.BursarManagerLogic;
using OBS.Core.Interfaces.BedManagerLogic;
using OBS.Core.Interfaces.BursarConfig;
using OBS.Core.Logic.BursarConfig;
using DotslashMiddleware.Services;
using DotslashMiddleware.Data;
using OBS.Core.Interfaces.Residential.ResidentailBursarValidation;
using OBS.Core.Logic.Residential.ResidentailBursarValidation;
using OBS.Core.Logic.Bursar;
using SP.Core.Security;
using SP.Core.Notifications;
using OBS.Utilities;
using OBS.Core.Logic.Services;
using OBS.Core.Interfaces.Services;
using OBS.Core.Logic.Booking;
using OBS.Core.Interfaces.Bookings;

namespace OBS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
            Configuration = configuration;
        }
        private IWebHostEnvironment _env { get; set; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            DateTime eastern = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Eastern Standard Time");

            var SqlConnectionString = Configuration.GetConnectionString("DefaultConnection");
            ConnectionStrings.Default = SqlConnectionString;

            var SOBSContextConnectionString = Configuration.GetConnectionString("SOBSContext");
            ConnectionStrings.SOBSContext = SOBSContextConnectionString;

            var OracleConnectionString = Configuration.GetConnectionString("OracleConnection");
            ConnectionStrings.OracleConnection = OracleConnectionString;

            var StagingDBEntitiesConnectionString = Configuration.GetConnectionString("StagingDBEntitiesConnection");
            ConnectionStrings.StagingDBEntitiesConnection = StagingDBEntitiesConnectionString;

            services.AddDbContext<SouthPointDbContext>(options =>
                options.UseSqlServer(
                    SqlConnectionString
                    //x => x.MigrationsAssembly("SouthPointMaintenance.Data.Migrations")
                   , b => b.MigrationsAssembly("OBS.API")
                    ));//.AddInterceptors(new UTCTimeInterceptor()));

            //services.AddDefaultIdentity<SouthPointMaintenance.Data.ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<SouthPointDbContext>();

            services.AddDefaultIdentity<SouthPointMaintenance.Data.ApplicationUser>(o =>
            {
                // configure identity options
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
            })
            .AddRoles<ApplicationRole>()
            .AddEntityFrameworkStores<SouthPointDbContext>()
            //.AddRoleManager<RoleManager<ApplicationRole>>()
            .AddRoleStore<ApplicationRoleStore>()
            .AddSignInManager<SignInManager<SouthPointMaintenance.Data.ApplicationUser>>()
            .AddDefaultTokenProviders();



            services.AddDbContext<OBSDbContext>(options =>
                options.UseSqlServer(
                SqlConnectionString, b => b.MigrationsAssembly("OBS.API")
                ));//.AddInterceptors(new UTCTimeInterceptor()));

            DotslashMiddlewareService.Configuration ??= new DotslashMiddlewareServiceModel() { };
            DotslashMiddlewareService.Configuration.Key = "3031CC6C-F7CB-4539-512B-08D87B32A4B9";
            DotslashMiddlewareService.Configuration.URL = "https://www.staysouthpoint.co.za/";

            var obsOptionsBuilder = new DbContextOptionsBuilder<OBSDbContext>();
            obsOptionsBuilder.UseSqlServer(SqlConnectionString, b => b.MigrationsAssembly("OBS.API"));
            var dboOptionsBuilder = new DbContextOptionsBuilder<SouthPointDbContext>();
            dboOptionsBuilder.UseSqlServer(SqlConnectionString);
            DbContextOptionsBuilder<SobsConfigurationContext> configurationOptionsBuilder = new DbContextOptionsBuilder<SobsConfigurationContext>();
            dboOptionsBuilder.UseSqlServer(SqlConnectionString);

            try
            {
                DatabaseManager.ConnectionString = (Configuration["ConnectionStrings:OracleSyncConnection"]);
            }
            catch { }
            services.AddScoped<IViewProvider, ViewProvider>();

            services.AddScoped<IViewProvider, ViewProvider>();
            services.AddSingleton(a => new SP.Utilities.Services.HostOptions() { Host = Configuration["AppSettings:MailHost"] });

            services.AddScoped<ISobsUnitOfWork, SobsUnitOfWork>();
            services.AddScoped<ISMSSender, SMSSender>();
            services.AddScoped<IEmailSender, MailGunEmailSender>();
            services.AddScoped<IScheduleViewingLogic, ScheduleViewingLogic>();

            services.AddScoped<IOracleLeaseLogic, OracleLeaseLogic>();
            services.AddScoped<RoomVacationManagement, RoomVacationManagement>();
            services.AddScoped<IUsersLogic, UsersLogic>();
            services.AddScoped<IRolesLogic, SPRolesLogic>();
            services.AddScoped<INotifier, Notifier>();
            services.AddScoped<IWordingProvider, WordingProvider>();
            services.AddScoped<DbContext, SouthPointDbContext>();

            services.AddScoped<ICityManagerLogic, CityManager>();
            services.AddScoped<IBuildingManagerLogic, BuildingManager>();
            services.AddScoped<IBursarManagerLogic, BursarManager>();
            services.AddScoped<IBedManagerLogic, BedManager>();
            services.AddScoped<IBursarConfigurationLogic, BursarConfigLogic>();
            services.AddScoped<IBursarLogic, BursarLogic>();

            services.AddScoped<IApplicationConfigurationLogic, ApplicationConfigurationLogic>();

            services.AddScoped<IFeeTypeBuildingBillingTypeTemplateLogic, FeeTypeBuildingBillingTypeTemplateLogic>();

            services.AddScoped<IStudentLogic, StudentLogic>();

            services.AddScoped<SOBSContainer, SOBSContainer>();

            services.AddScoped<IOracleLogic, OracleLogic>();

            services.AddScoped<IUserLogic, UserLogic>();

            services.AddScoped<IBuildingLogic, BuildingLogic>();

            services.AddScoped<IResidentialLeaseLogic, ResidentialLeaseLogic>();

            services.AddScoped<IBiometricLogic, BiometricLogic>();

            services.AddScoped<IEmailLogic, EmailManager>();

            services.AddScoped<IMsSQLLogic, MsSQLLogic>();

            services.AddScoped<IRoleLogic, RoleLogic>();
            services.AddScoped<IBitVenture, BitVenture>();
            services.AddScoped<IBookingsLogic, BookingLogic>();

            services.AddScoped<IAccessManager, AccessManager>();

            services.AddSingleton<ILog>(LogManager.GetLogger("SobsRobsIocContainer"));

            services.AddScoped<IOracleCustomerLogic, OracleCustomerLogic>();

            services.AddScoped<IHeadLeaseLogic, HeadLeaseLogic>();

            services.AddScoped<IApartmentLogic, ApartmentLogic>();
            services.AddScoped<ILeaseSendingLogic, LeaseSendingLogic>();

            services.AddScoped<IOracleFinanceLogic, OracleFinanceLogic>();
            services.AddScoped<IBursarValidationLogic, BursarValidationLogic>();
            //services.AddScoped<IBursarValidation, BursarValidation>();

            var contractResolver = new SerializableContractResolver();
            contractResolver.NamingStrategy = new CamelCaseNamingStrategy();

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = contractResolver;
                options.SerializerSettings.TypeNameHandling = TypeNameHandling.None;
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "South Point API", Version = "v1" });

                // To Enable authorization using Swagger (JWT)    
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });

                //Resolve apiDescriptions conflict
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlFilePath))
                    c.IncludeXmlComments(xmlFilePath);

                //Add note on roles for methods requiring authentication
                c.OperationFilter<SwaggerAppendAuthorizeToSummaryOperationFilter>();
                //Filter user visible methods
                c.DocumentFilter<SwaggerAuthorizeRoleFilter>();
                //Ignore properties with [SwaggerIgnore] attribute
                c.SchemaFilter<SwaggerIgnoreFilter>();
                //Filter to manager response header documentation
                c.OperationFilter<ResponseHeaderFilter>();

                //Register the Swagger generator, defining 1 or more Swagger documents
                var commonDescription = "Login";
                var swaggerAuthenticatedDescription = commonDescription;
                swaggerAuthenticatedDescription += "\r\n";
                swaggerAuthenticatedDescription += "\r\nSouthpoint API";

                var swaggerDescription = commonDescription;
                swaggerDescription += "\r\n";
                swaggerDescription += "\r\n";

                c.DocumentFilter<SwaggerAuthenticatedDescriptionFilter>(swaggerDescription, swaggerAuthenticatedDescription);

            });
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                                  }
                                  );
            });
            // Adding Authentication  
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            // Adding Jwt Bearer  
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidAudience = Configuration["JWT:JwtAudience"],
                    ValidIssuer = Configuration["JWT:JwtIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:JwtSecurityKey"]))
                };
            });

            SPGlobals.DEBTORS = Configuration.GetConnectionString("SQLDebtorsConnection"); 
            SPGlobals.DEFAULT = SqlConnectionString; 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "south_point_api v1");
                c.InjectStylesheet("/swagger/swagger.css");
                c.InjectJavascript("/swagger/swagger.js");
                c.DefaultModelsExpandDepth(-1);
            });

            app.UseCors();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
