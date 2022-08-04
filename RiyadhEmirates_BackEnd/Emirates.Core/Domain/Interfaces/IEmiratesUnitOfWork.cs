using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;

namespace Emirates.Core.Domain.Interfaces
{
    public interface IEmiratesUnitOfWork : IUnitOfWork
    {
        ICaseTypeRepository CaseTypes { get; }
        INationalityRepository Nationalities { get; }
        INewsRepository News { get; }
        IRequestRepository Requests { get; }
        IRequestAttachmentTypeRepository RequestAttachmentTypes { get; }
        IRequestPrisonersServiceRepository RequestPrisonersServices { get; }
        IRequestPrisonerTempReleaseRepository RequestPrisonerTempReleases { get; }
        IRequestStageLogRepository RequestStageLogs { get; }
        IRequestTypeRepository RequestTypes { get; }
        IServiceRepository Services { get; }
        IServiceRateRepository ServiceRates { get; }
        IServiceStageRepository ServiceStages { get; }
        IStageRepository Stages { get; }
        IUploadedFileRepository UploadedFiles { get; }
        IUserRepository Users { get; }
    }
}
