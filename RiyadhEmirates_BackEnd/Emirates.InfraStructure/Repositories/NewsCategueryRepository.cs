using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class NewsCategueryRepository : Repository<NewsCateguery, EmiratesContext>, INewsCategueryRepository
    {
        public NewsCategueryRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
