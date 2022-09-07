using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;

namespace Emirates.Core.Domain.Interfaces
{
    public interface IEmiratesUnitOfWork : IUnitOfWork
    {
        ICaseTypeRepository CaseTypes { get; }
        INationalityRepository Nationalities { get; }
        INewsRepository News { get; }
        IPosterRepository Posters { get; }
        IRequestRepository Requests { get; }
        IRequestAttachmentTypeRepository RequestAttachmentTypes { get; }
        IRequestElectronicBoardRepository RequestElectronicBoards { get; }
        IRequestElectronicSummonRepository RequestElectronicSummons { get; }
        IRequestForeignersRealtyOwnerRepository RequestForeignersRealtyOwners { get; }
        IRequestJudgmentExecutionRepository RequestJudgmentExecutions { get; }
        IRequestLandsInfringementRepository RequestLandsInfringements { get; }
        IRequestMarriageCertificateRepository RequestMarriageCertificates { get; }
        IRequestPrisonersServiceRepository RequestPrisonersServices { get; }
        IRequestPrisonerTempReleaseRepository RequestPrisonerTempReleases { get; }
        IRequestStageLogRepository RequestStageLogs { get; }
        IRequestTreatmentRecommendationRepository RequestTreatmentRecommendations { get; }
        IRequestTypeRepository RequestTypes { get; }
        IServiceAudienceRepository ServiceAudiences { get; }
        IServiceBenefitRepository ServiceBenefits { get; }
        IServiceConditionRepository ServiceConditions { get; }
        IServiceRateRepository ServiceRates { get; }
        IServiceRepository Services { get; }
        IServiceStageRepository ServiceStages { get; }
        IStageRepository Stages { get; }
        IUploadedFileRepository UploadedFiles { get; }
        IUserRepository Users { get; }
        ILookupRepository Lookups { get; }
    }
}
