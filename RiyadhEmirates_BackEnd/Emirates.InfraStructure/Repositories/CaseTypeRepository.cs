using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class CaseTypeRepository : Repository<CaseType, EmiratesContext>, ICaseTypeRepository
    {
        public CaseTypeRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
