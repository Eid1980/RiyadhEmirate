using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestMarriageCertificateRepository : Repository<RequestMarriageCertificate, EmiratesContext>, IRequestMarriageCertificateRepository
    {
        public RequestMarriageCertificateRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
