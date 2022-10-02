using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class NewsSubscriperRepository : Repository<NewsSubscriper, EmiratesContext>, INewsSubscriperRepository
    {
        public NewsSubscriperRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
