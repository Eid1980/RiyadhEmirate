using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class ServiceRateRepository : Repository<ServiceRate, EmiratesContext> , IServiceRateRepository
    {
        public ServiceRateRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
