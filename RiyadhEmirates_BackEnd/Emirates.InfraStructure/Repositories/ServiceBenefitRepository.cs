using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class ServiceBenefitRepository : Repository<ServiceBenefit, EmiratesContext>, IServiceBenefitRepository
    {
        public ServiceBenefitRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
