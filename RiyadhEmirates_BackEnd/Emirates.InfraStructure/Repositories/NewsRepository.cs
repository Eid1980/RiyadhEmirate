using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class NewsRepository: Repository<News, EmiratesContext>, INewsRepository
    {
        public NewsRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
