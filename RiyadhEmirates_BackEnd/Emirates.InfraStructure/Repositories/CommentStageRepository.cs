using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class CommentStageRepository : Repository<CommentStage, EmiratesContext>, ICommentStageRepository
    {
        public CommentStageRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
