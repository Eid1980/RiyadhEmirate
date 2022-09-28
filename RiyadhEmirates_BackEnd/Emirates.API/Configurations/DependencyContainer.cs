using Emirates.Core.Application.Services;
using Emirates.Core.Application.Services.AboutUs;
using Emirates.Core.Application.Services.Accounts;
using Emirates.Core.Application.Services.CaseTypes;
using Emirates.Core.Application.Services.Common;
using Emirates.Core.Application.Services.Governorates;
using Emirates.Core.Application.Services.Home;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
using Emirates.Core.Application.Services.LatestNews;
using Emirates.Core.Application.Services.LatestNewsComments;
using Emirates.Core.Application.Services.Lookups;
using Emirates.Core.Application.Services.Nationality;
using Emirates.Core.Application.Services.News;
using Emirates.Core.Application.Services.NewsCategueries;
using Emirates.Core.Application.Services.Posters;
using Emirates.Core.Application.Services.RequestAttachmentTypes;
using Emirates.Core.Application.Services.RequestElectronicBoards;
using Emirates.Core.Application.Services.RequestElectronicSummons;
using Emirates.Core.Application.Services.RequestForeignersRealtyOwners;
using Emirates.Core.Application.Services.RequestJudgmentExecutions;
using Emirates.Core.Application.Services.RequestLandsInfringements;
using Emirates.Core.Application.Services.RequestMarriageCertificates;
using Emirates.Core.Application.Services.RequestPrisonersServices;
using Emirates.Core.Application.Services.RequestPrisonerTempReleases;
using Emirates.Core.Application.Services.Requests;
using Emirates.Core.Application.Services.RequestTreatmentRecommendations;
using Emirates.Core.Application.Services.RequestTypes;
using Emirates.Core.Application.Services.Roles;
using Emirates.Core.Application.Services.ServiceAudiences;
using Emirates.Core.Application.Services.ServiceBenefits;
using Emirates.Core.Application.Services.ServiceConditions;
using Emirates.Core.Application.Services.ServiceRates;
using Emirates.Core.Application.Services.ServiceStages;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Services.UserRoles;
using Emirates.Core.Application.Services.WomanSection;
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
            builder.Services.AddScoped<IHomeService, HomeService>();
            builder.Services.AddScoped<IAboutUsService, AboutUsService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<ICaseTypeService, CaseTypeService>();
            builder.Services.AddScoped<IGovernorateService, GovernorateService>();
            builder.Services.AddScoped<ILocalizationService, LocalizationService>();
            builder.Services.AddScoped<IFileManagerService, FileManagerService>();
            builder.Services.AddScoped<IFileUploaderService, FileUploaderService>();
            builder.Services.AddScoped<ILatestNewsService, LatestNewsService>();
            builder.Services.AddScoped<ILatestNewsCommentService, LatestNewsCommentService>();
            builder.Services.AddScoped<INewsService, NewsService>();
            builder.Services.AddScoped<INewsCategueryService, NewsCategueryService>();
            builder.Services.AddScoped<IPosterService, PosterService>();
            builder.Services.AddScoped<IServicesService, ServicesService>();
            builder.Services.AddScoped<IServiceAudienceService, ServiceAudienceService>();
            builder.Services.AddScoped<IServiceConditionService, ServiceConditionService>();
            builder.Services.AddScoped<IServiceBenefitService, ServiceBenefitService>();
            builder.Services.AddScoped<IServiceRateService, ServiceRateService>();
            builder.Services.AddScoped<IServiceStageService, ServiceStageService>();
            builder.Services.AddScoped<INationalityService, NationalityService>();

            builder.Services.AddScoped<ICommonService, CommonService>();

            builder.Services.AddScoped<IRequestService, RequestService>();
            builder.Services.AddScoped<IRequestAttachmentTypeService, RequestAttachmentTypeService>();
            builder.Services.AddScoped<IRequestElectronicBoardService, RequestElectronicBoardService>();
            builder.Services.AddScoped<IRequestElectronicSummonService, RequestElectronicSummonService>();
            builder.Services.AddScoped<IRequestJudgmentExecutionService, RequestJudgmentExecutionService>();
            builder.Services.AddScoped<IRequestLandsInfringementService, RequestLandsInfringementService>();
            builder.Services.AddScoped<IRequestMarriageCertificateService, RequestMarriageCertificateService>();
            builder.Services.AddScoped<IRequestTypeService, RequestTypeService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IRequestPrisonersServiceService, RequestPrisonersServiceService>();
            builder.Services.AddScoped<IRequestPrisonerTempReleaseService, RequestPrisonerTempReleaseService>();
            builder.Services.AddScoped<IRequestForeignersRealtyOwnerService, RequestForeignersRealtyOwnerService>();
            builder.Services.AddScoped<IRequestTreatmentRecommendationService, RequestTreatmentRecommendationService>();

            builder.Services.AddScoped<IWomanSectionService, WomanSectionService>();
            builder.Services.AddScoped<IUserRoleService, UserRoleService>();

        }
    }
}
