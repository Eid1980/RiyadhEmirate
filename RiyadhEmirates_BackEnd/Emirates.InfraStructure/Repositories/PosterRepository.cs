using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class PosterRepository: Repository<Poster, EmiratesContext>, IPosterRepository
    {
        public PosterRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
