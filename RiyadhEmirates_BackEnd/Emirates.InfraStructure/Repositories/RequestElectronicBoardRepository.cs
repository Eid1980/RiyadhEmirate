using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestElectronicBoardRepository : Repository<RequestElectronicBoard, EmiratesContext>, IRequestElectronicBoardRepository
    {
        public RequestElectronicBoardRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
