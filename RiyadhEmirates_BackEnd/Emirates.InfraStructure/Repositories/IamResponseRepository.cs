using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class IamResponseRepository : Repository<IamResponse, EmiratesContext>, IIamResponseRepository
    {
        public IamResponseRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
