using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class NewsCommentRepository : Repository<NewsComment, EmiratesContext>, INewsCommentRepository
    {
        public NewsCommentRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
