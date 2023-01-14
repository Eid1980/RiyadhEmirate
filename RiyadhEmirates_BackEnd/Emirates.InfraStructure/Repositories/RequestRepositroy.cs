using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestRepositroy : Repository<Request, EmiratesContext>, IRequestRepository
    {
        public RequestRepositroy(EmiratesContext context) : base(context)
        {
        }
        public long GetNextRequestNumber()
        {
            return _context.Set<RequestNumberSequence>().ToList()[0].Value;
        }
    }
}
