using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RoleRepository : Repository<Role, EmiratesContext>, IRoleRepository
    {
        public RoleRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
