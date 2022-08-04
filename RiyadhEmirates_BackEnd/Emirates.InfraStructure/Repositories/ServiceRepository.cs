using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories.Security
{
    public class ServiceRepository : Repository<Service, EmiratesContext>, IServiceRepository
    {
        public ServiceRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
