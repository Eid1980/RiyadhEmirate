using Emirates.Core.Domain.Interfaces;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories;
using Emirates.InfraStructure.Repositories.Security;

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
        private CaseTypeRepository caseTypes;
        public ICaseTypeRepository CaseTypes => caseTypes ??= new CaseTypeRepository(Context);


        private NationalityRepository nationalities;
        public INationalityRepository Nationalities => nationalities ??= new NationalityRepository(Context);


        private NewsRepository news;
        public INewsRepository News => news ??= new NewsRepository(Context);


        private PosterRepository posters;
        public IPosterRepository Posters => posters ??= new PosterRepository(Context);

        private RequestRepositroy requests;
        public IRequestRepository Requests => requests ??= new RequestRepositroy(Context);


        private RequestAttachmentTypeRepository requestAttachmentTypes;
        public IRequestAttachmentTypeRepository RequestAttachmentTypes => requestAttachmentTypes ??=  new RequestAttachmentTypeRepository(Context);


        private RequestPrisonersServiceRepository requestPrisonersServices;
        public IRequestPrisonersServiceRepository RequestPrisonersServices => requestPrisonersServices ??= new RequestPrisonersServiceRepository(Context);


        private RequestLandsInfringementRepository requestLandsInfringements;
        public IRequestLandsInfringementRepository RequestLandsInfringements => requestLandsInfringements ??= new RequestLandsInfringementRepository(Context);
        

        private RequestPrisonerTempReleaseRepository requestPrisonerTempReleases;
        public IRequestPrisonerTempReleaseRepository RequestPrisonerTempReleases => requestPrisonerTempReleases ??= new RequestPrisonerTempReleaseRepository(Context);


        private IRequestStageLogRepository requestStageLogs;
        public IRequestStageLogRepository RequestStageLogs => requestStageLogs ??= new RequestStageLogRepository(Context);


        private RequestTypeRepository requestTypes;
        public IRequestTypeRepository RequestTypes => requestTypes ??=  new RequestTypeRepository(Context);

        
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
