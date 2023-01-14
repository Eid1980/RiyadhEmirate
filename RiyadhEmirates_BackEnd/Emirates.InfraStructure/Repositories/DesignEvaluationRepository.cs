using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class DesignEvaluationRepository : Repository<DesignEvaluation, EmiratesContext>, IDesignEvaluationRepository
    {
        public DesignEvaluationRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
