using Emirates.Core.Domain.Entities;

namespace Emirates.Core.Domain.Interfaces.Repositories
{
    public interface IRequestRepository : IRepository<Request>
    {
        long GetNextRequestNumber();
    }
}
