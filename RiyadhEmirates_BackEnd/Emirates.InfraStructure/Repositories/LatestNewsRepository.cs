using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class LatestNewsRepository : Repository<LatestNews, EmiratesContext>, ILatestNewsRepository
    {
        public LatestNewsRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
