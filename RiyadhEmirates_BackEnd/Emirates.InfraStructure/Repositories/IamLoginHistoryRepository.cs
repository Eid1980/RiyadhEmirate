using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class IamLoginHistoryRepository : Repository<IamLoginHistory, EmiratesContext>, IIamLoginHistoryRepository
    {
        public IamLoginHistoryRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
