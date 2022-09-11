using Emirates.Core.Domain.Interfaces;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories;

namespace Emirates.InfraStructure.UnitsOfWork
{
    public class EmiratesUnitOfWork : UnitOfWork<EmiratesContext>, IEmiratesUnitOfWork
    {
        public EmiratesUnitOfWork(EmiratesContext context) : base (context) {  }

        #region Methods
        public override IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity, EmiratesContext>(Context);
        }
        #endregion

        #region Repositories
        private AudienceRepository audiences;
        public IAudienceRepository Audiences => audiences ??= new AudienceRepository(Context);


        private CaseTypeRepository caseTypes;
        public ICaseTypeRepository CaseTypes => caseTypes ??= new CaseTypeRepository(Context);


        private NationalityRepository nationalities;
        public INationalityRepository Nationalities => nationalities ??= new NationalityRepository(Context);


        private LatestNewsRepository latestNews;
        public ILatestNewsRepository LatestNews => latestNews ??= new LatestNewsRepository(Context);


        private LatestNewsCommentRepository latestNewsComments;
        public ILatestNewsCommentRepository LatestNewsComments => latestNewsComments ??= new LatestNewsCommentRepository(Context);


        private NewsRepository news;
        public INewsRepository News => news ??= new NewsRepository(Context);


        private NewsCategueryRepository newsCategueries;
        public INewsCategueryRepository NewsCategueries => newsCategueries ??= new NewsCategueryRepository(Context);


        private PosterRepository posters;
        public IPosterRepository Posters => posters ??= new PosterRepository(Context);


        private RequestRepositroy requests;
        public IRequestRepository Requests => requests ??= new RequestRepositroy(Context);


        private RequestAttachmentTypeRepository requestAttachmentTypes;
        public IRequestAttachmentTypeRepository RequestAttachmentTypes => requestAttachmentTypes ??=  new RequestAttachmentTypeRepository(Context);


        private RequestElectronicBoardRepository requestElectronicBoards;
        public IRequestElectronicBoardRepository RequestElectronicBoards => requestElectronicBoards ??=  new RequestElectronicBoardRepository(Context);


        private RequestElectronicSummonRepository requestElectronicSummons;
        public IRequestElectronicSummonRepository RequestElectronicSummons => requestElectronicSummons ??=  new RequestElectronicSummonRepository(Context);
        

        private RequestForeignersRealtyOwnerRepository requestForeignersRealtyOwners;
        public IRequestForeignersRealtyOwnerRepository RequestForeignersRealtyOwners => requestForeignersRealtyOwners ??=  new RequestForeignersRealtyOwnerRepository(Context);


        private RequestJudgmentExecutionRepository requestJudgmentExecutions;
        public IRequestJudgmentExecutionRepository RequestJudgmentExecutions => requestJudgmentExecutions ??= new RequestJudgmentExecutionRepository(Context);


        private RequestLandsInfringementRepository requestLandsInfringements;
        public IRequestLandsInfringementRepository RequestLandsInfringements => requestLandsInfringements ??= new RequestLandsInfringementRepository(Context);


        private RequestMarriageCertificateRepository requestMarriageCertificates;
        public IRequestMarriageCertificateRepository RequestMarriageCertificates => requestMarriageCertificates ??= new RequestMarriageCertificateRepository(Context);


        private RequestPrisonersServiceRepository requestPrisonersServices;
        public IRequestPrisonersServiceRepository RequestPrisonersServices => requestPrisonersServices ??= new RequestPrisonersServiceRepository(Context);


        private RequestPrisonerTempReleaseRepository requestPrisonerTempReleases;
        public IRequestPrisonerTempReleaseRepository RequestPrisonerTempReleases => requestPrisonerTempReleases ??= new RequestPrisonerTempReleaseRepository(Context);


        private IRequestStageLogRepository requestStageLogs;
        public IRequestStageLogRepository RequestStageLogs => requestStageLogs ??= new RequestStageLogRepository(Context);


        private RequestTreatmentRecommendationRepository requestTreatmentRecommendations;
        public IRequestTreatmentRecommendationRepository RequestTreatmentRecommendations => requestTreatmentRecommendations ??= new RequestTreatmentRecommendationRepository(Context);


        private RequestTypeRepository requestTypes;
        public IRequestTypeRepository RequestTypes => requestTypes ??=  new RequestTypeRepository(Context);


        private ServiceAudienceRepository serviceAudiences;
        public IServiceAudienceRepository ServiceAudiences => serviceAudiences ??= new ServiceAudienceRepository(Context);


        private ServiceBenefitRepository serviceBenefits;
        public IServiceBenefitRepository ServiceBenefits => serviceBenefits ??= new ServiceBenefitRepository(Context);

        
        private ServiceConditionRepository serviceConditions;
        public IServiceConditionRepository ServiceConditions => serviceConditions ??= new ServiceConditionRepository(Context);


        private ServiceRepository services;
        public IServiceRepository Services => services ??= new ServiceRepository(Context);


        private ServiceRateRepository serviceRates;
        public IServiceRateRepository ServiceRates => serviceRates ??=  new ServiceRateRepository(Context);


        private ServiceStageRepository serviceStages;
        public IServiceStageRepository ServiceStages => serviceStages ??=  new ServiceStageRepository(Context);


        private StageRepository stages;
        public IStageRepository Stages => stages ??=  new StageRepository(Context);


        private UploadedFileRepository uploadedFiles;
        public IUploadedFileRepository UploadedFiles => uploadedFiles ??= new UploadedFileRepository(Context);


        private UserRepository users;
        public IUserRepository Users => users ??= new UserRepository(Context);


        private LookupRepository lookups;
        public ILookupRepository Lookups => lookups ??= new LookupRepository(Context);
        #endregion

    }
}
