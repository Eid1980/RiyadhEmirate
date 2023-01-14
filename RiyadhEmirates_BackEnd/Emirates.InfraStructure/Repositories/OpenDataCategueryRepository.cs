using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;


namespace Emirates.InfraStructure.Repositories
{
    public class OpenDataCategueryRepository : Repository<OpenDataCateguery, EmiratesContext>, IOpenDataCategueryRepository
    {
        public OpenDataCategueryRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
