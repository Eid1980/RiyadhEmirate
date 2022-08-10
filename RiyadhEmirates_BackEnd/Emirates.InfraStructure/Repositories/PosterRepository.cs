using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class PosterRepository: Repository<Poster, EmiratesContext>, IPosterRepository
    {
        public PosterRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
