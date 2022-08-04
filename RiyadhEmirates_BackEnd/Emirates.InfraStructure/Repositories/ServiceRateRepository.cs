
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class ServiceRateRepository : Repository<ServiceRate, EmiratesContext> , IServiceRateRepository
    {
        public ServiceRateRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
