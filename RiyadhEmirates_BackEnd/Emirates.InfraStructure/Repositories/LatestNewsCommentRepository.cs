using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class LatestNewsCommentRepository : Repository<LatestNewsComment, EmiratesContext>, ILatestNewsCommentRepository
    {
        public LatestNewsCommentRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
