using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;


namespace Emirates.InfraStructure.Repositories
{
    public class ServiceConditionRepository : Repository<ServiceCondition, EmiratesContext>, IServiceConditionRepository
    {
        public ServiceConditionRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
