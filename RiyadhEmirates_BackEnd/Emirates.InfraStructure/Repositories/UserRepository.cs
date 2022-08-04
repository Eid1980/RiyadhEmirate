using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories.Security
{
    public class UserRepository : Repository<User, EmiratesContext>, IUserRepository
    {
        public UserRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
