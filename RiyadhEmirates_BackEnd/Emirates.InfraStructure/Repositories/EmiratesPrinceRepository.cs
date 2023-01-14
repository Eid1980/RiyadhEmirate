using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class EmiratesPrinceRepository : Repository<EmiratesPrince, EmiratesContext>, IEmiratesPrinceRepository
    {
        public EmiratesPrinceRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
