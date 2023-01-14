using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;


namespace Emirates.InfraStructure.Repositories
{
    public class ContactUsMessageRepository : Repository<ContactUsMessage, EmiratesContext>, IContactUsMessageRepository
    {
        public ContactUsMessageRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
