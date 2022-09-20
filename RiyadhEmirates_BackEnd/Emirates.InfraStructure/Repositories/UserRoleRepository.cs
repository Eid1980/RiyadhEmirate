using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class UserRoleRepository : Repository<UserRole, EmiratesContext>, IUserRoleRepository
    {
        public UserRoleRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
