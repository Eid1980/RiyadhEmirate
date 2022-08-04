using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestPrisonersServiceRepository : Repository<RequestPrisonersService, EmiratesContext>, IRequestPrisonersServiceRepository
    {
        public RequestPrisonersServiceRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
