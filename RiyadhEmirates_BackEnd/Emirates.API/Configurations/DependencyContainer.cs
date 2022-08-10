using Emirates.Core.Application.Services;
using Emirates.Core.Application.Services.Accounts;
using Emirates.Core.Application.Services.CaseTypes;
using Emirates.Core.Application.Services.Common;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
using Emirates.Core.Application.Services.Lookups;
using Emirates.Core.Application.Services.Nationality;
using Emirates.Core.Application.Services.News;
using Emirates.Core.Application.Services.Posters;
using Emirates.Core.Application.Services.RequestAttachmentTypes;
using Emirates.Core.Application.Services.RequestPrisonersServices;
using Emirates.Core.Application.Services.RequestPrisonerTempReleases;
using Emirates.Core.Application.Services.Requests;
using Emirates.Core.Application.Services.RequestTypes;
using Emirates.Core.Application.Services.ServiceRates;
using Emirates.Core.Application.Services.ServiceStages;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Domain.Interfaces;
using Emirates.InfraStructure.UnitsOfWork;

namespace Emirates.API.Configurations
{
    public class DependencyContainer
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            #region UnitOfWorks
            builder.Services.AddScoped<IEmiratesUnitOfWork, EmiratesUnitOfWork>();
            #endregion

            builder.Services.AddScoped<ILookupService, LookupService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<ICaseTypeService, CaseTypeService>();
            builder.Services.AddScoped<ILocalizationService, LocalizationService>();
            builder.Services.AddScoped<IFileManagerService, FileManagerService>();
            builder.Services.AddScoped<IFileUploaderService, FileUploaderService>();
            builder.Services.AddScoped<INewsService, NewsService>();
            builder.Services.AddScoped<IPosterService, PosterService>();
            builder.Services.AddScoped<IServicesService, ServicesService>();
            builder.Services.AddScoped<IServiceRateService, ServiceRateService>();
            builder.Services.AddScoped<IServiceStageService, ServiceStageService>();
            builder.Services.AddScoped<INationalityService, NationalityService>();

            builder.Services.AddScoped<ICommonService, CommonService>();

            builder.Services.AddScoped<IRequestService, RequestService>();
            builder.Services.AddScoped<IRequestAttachmentTypeService, RequestAttachmentTypeService>();
            builder.Services.AddScoped<IRequestTypeService, RequestTypeService>();
            builder.Services.AddScoped<IRequestPrisonersServiceService, RequestPrisonersServiceService>();
            builder.Services.AddScoped<IRequestPrisonerTempReleaseService, RequestPrisonerTempReleaseService>();
        }
    }
}
