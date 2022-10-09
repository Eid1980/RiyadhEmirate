using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Emirates.API.Configurations.AutoMapper;
using Emirates.API.Filters.Swagger;
using Emirates.Core.Application.CustomExceptions;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Loggers.Serilog;
using Serilog;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Text;
using Emirates.API.Configurations;
using System.Text.Json;
using Emirates.Core.Application.Dtos;

Serilog.Debugging.SelfLog.Enable(msg => Debug.WriteLine(msg));
//Read Configuration from appSettings
var config = SerilogHelper.BuildConfiguration();

//Initialize static logger using the settings from appsettings
Log.Logger = SerilogHelper.InitializeStaticLogger(config);

try
{
    Log.Information("Application Starting.");

    var builder = WebApplication.CreateBuilder(args);
    builder.Host.UseSerilog();

    ConfigurationManager configuration = builder.Configuration;
    IWebHostEnvironment environment = builder.Environment;

    // Add services to the container.
    #region Configure Services
    builder.Services.AddControllers()
        .AddJsonOptions(opts => 
                        opts.JsonSerializerOptions.PropertyNamingPolicy =  JsonNamingPolicy.CamelCase
                        //opts.JsonSerializerOptions.PropertyNamingPolicy = null
                       );

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();

    #region Swagger
    // Register the Swagger generator, defining 1 or more Swagger documents
    builder.Services.AddSwaggerGen(c =>
    {
        //c.MapType<DateTime>(() => new OpenApiSchema { Format = "dd/MM/yyyy" });
        //c.MapType<DateTime?>(() => new OpenApiSchema { Format = "dd/MM/yyyy" });
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Emirates APIs", Version = "1.0.0" });

        // Set the comments path for the Swagger JSON and UI.
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);

        //Enable Authentication
        c.AddSecurityDefinition("JWT",
            new OpenApiSecurityScheme
            {
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Please insert JWT with Bearer into field",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
            });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme {
                        Reference = new OpenApiReference {
                            Type = ReferenceType.SecurityScheme,
                            Id = "JWT"
                        }
                    },
                    Array.Empty<string>()
                    }
                });

        c.OperationFilter<AcceptLanguageHeaderOperationFilter>();
    });
    #endregion

    #region Mappers
    builder.Services.AddSingleton(AutoMapperConfigurations.GetMapper());
    #endregion

    #region Localization
    builder.Services.AddLocalization();

    // Configure supported cultures and localization options
    builder.Services.Configure<RequestLocalizationOptions>(options =>
    {
        var supportedCultures = new[]
        {
                    new CultureInfo("en"),
                    new CultureInfo("ar")
                };

        // State what the default culture for your application is. This will be used if no specific culture
        // can be determined for a given request.
        options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");

        // You must explicitly state which cultures your application supports.
        // These are the cultures the app supports for formatting numbers, dates, etc.
        options.SupportedCultures = supportedCultures;

        // These are the cultures the app supports for UI strings, i.e. we have localized resources for.
        options.SupportedUICultures = supportedCultures;

        // You can change which providers are configured to determine the culture for requests, or even add a custom
        // provider with your own logic. The providers will be asked in order to provide a culture for each request,
        // and the first to provide a non-null result that is in the configured supported cultures list will be used.
        // By default, the following built-in providers are configured:
        // - QueryStringRequestCultureProvider, sets culture via "culture" and "ui-culture" query string values, useful for testing
        // - CookieRequestCultureProvider, sets culture via "ASPNET_CULTURE" cookie
        // - AcceptLanguageHeaderRequestCultureProvider, sets culture via the "Accept-Language" request header
        //options.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(async context =>
        //{
        //  // My custom request culture logic
        //  return new ProviderCultureResult("en");
        //}));
    });
    #endregion

    #region Authentication
    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(configuration.GetSection("AppSettings:TokenSigningKey").Value)
                ),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
    #endregion

    #region DBContexts
    builder.Services.AddDbContext<EmiratesContext>(optionsBuilder =>
    {
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure();
        });
    });

    #endregion

    #region UnitOfWorks
    //builder.Services.AddScoped<IEmiratesUnitOfWork, EmiratesUnitOfWork>();
    #endregion

    #region services
    DependencyContainer.RegisterServices(builder);

    //builder.Services.AddScoped<IUserService, UserService>();
    //builder.Services.AddScoped<IRequestService, RequestService>();
    //builder.Services.AddScoped<ILocalizationService, LocalizationService>();
    //builder.Services.AddScoped<IFileManagerService, FileManagerService>();
    //builder.Services.AddScoped<IFileUploaderService, FileUploaderService>();
    //builder.Services.AddScoped<ILatestNewsService, LatestNewsService>();
    //builder.Services.AddScoped<IReportsService, ReportsService>();
    //builder.Services.AddScoped<IEmiratesNewsService, EmiratesNewsService>();
    //builder.Services.AddScoped<IServiceService, ServiceService>();
    //builder.Services.AddScoped<IServiceRateService, ServiceRateService>();
    //builder.Services.AddScoped<INationalityService, NationalityService>();
    //builder.Services.AddScoped<IMailService, MailService>();
    
    builder.Services.Configure<MailSettingsDto>(configuration.GetSection("MailSettings"));
    


    #endregion

    builder.Services.AddHttpContextAccessor();

    #endregion

    var app = builder.Build();

    //ConfigurationManager configuration = builder.Configuration;
    //IWebHostEnvironment environment = builder.Environment;

    // Configure the HTTP request pipeline.
    #region Configure
    app.UseRequestLocalization();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseDeveloperExceptionPage();
    }

    app.UseExceptionHandler(builder =>
    {
        builder.Run(async context =>
        {
            // Get error details
            var exceptionHandler = context.Features.Get<IExceptionHandlerFeature>();
            if (exceptionHandler != null)
            {
                if (exceptionHandler.Error is NotFoundException)
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                else if (exceptionHandler.Error is BusinessException)
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                else
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.Headers.AcceptEncoding = "UTF-8";
                context.Response.AddApplicationErrorHeader(exceptionHandler.Error.Message);
                await context.Response.WriteAsync(exceptionHandler.Error.Message);
            }
        });
    });


    app.UseHttpsRedirection();

    app.UseStaticFiles();

    app.UseSerilogRequestLogging();

    #region Swagger
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
    #endregion

    app.UseRouting();

    #region CORS
    //CORS must be after UseRouting and before UseAuthorization & UseEndpoints
    app.UseCors(x => x.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader());
    #endregion

    #region Authentication and Autorization
    // UseAuthentication is placed just before UseAuthorization
    app.UseAuthentication();
    app.UseAuthorization();
    #endregion

    app.MapControllers();

    app.Run();

    #endregion
}
catch (Exception ex)
{
    Log.Fatal(ex, "The Application failed to start.");
}
finally
{
    //Allows the logger to log any pending messages while the application closes down
    Log.CloseAndFlush();
}




