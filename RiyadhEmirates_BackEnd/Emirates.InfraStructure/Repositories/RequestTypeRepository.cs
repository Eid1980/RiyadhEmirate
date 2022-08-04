using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestTypeRepository : Repository<RequestType, EmiratesContext>, IRequestTypeRepository
    {
        public RequestTypeRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
