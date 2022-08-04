using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class ServiceStageRepository : Repository<ServiceStage, EmiratesContext>, IServiceStageRepository
    {
        public ServiceStageRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
