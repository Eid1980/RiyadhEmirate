using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestElectronicBoardRepository : Repository<RequestElectronicBoard, EmiratesContext>, IRequestElectronicBoardRepository
    {
        public RequestElectronicBoardRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
