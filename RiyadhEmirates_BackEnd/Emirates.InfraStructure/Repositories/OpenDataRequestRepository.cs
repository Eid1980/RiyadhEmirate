using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class OpenDataRequestRepository : Repository<OpenDataRequest, EmiratesContext>, IOpenDataRequestRepository
    {
        public OpenDataRequestRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
