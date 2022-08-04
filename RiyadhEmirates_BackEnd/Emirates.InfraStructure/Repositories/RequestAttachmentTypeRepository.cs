using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestAttachmentTypeRepository : Repository<RequestAttachmentType, EmiratesContext>, IRequestAttachmentTypeRepository
    {
        public RequestAttachmentTypeRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
