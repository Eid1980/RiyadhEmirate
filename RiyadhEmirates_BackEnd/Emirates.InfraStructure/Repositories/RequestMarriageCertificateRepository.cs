using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestMarriageCertificateRepository : Repository<RequestMarriageCertificate, EmiratesContext>, IRequestMarriageCertificateRepository
    {
        public RequestMarriageCertificateRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
