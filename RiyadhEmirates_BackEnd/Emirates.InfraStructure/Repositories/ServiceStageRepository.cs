using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class ServiceStageRepository : Repository<ServiceStage, EmiratesContext>, IServiceStageRepository
    {
        public ServiceStageRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
