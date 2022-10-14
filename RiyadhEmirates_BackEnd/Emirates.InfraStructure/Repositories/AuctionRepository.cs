using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class AuctionRepository : Repository<Auction, EmiratesContext>, IAuctionRepository
    {
        public AuctionRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
