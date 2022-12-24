using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;


namespace Emirates.InfraStructure.Repositories
{
    public class ServieNotificationLogRepository : Repository<ServieNotificationLog, EmiratesContext>, IServieNotificationLogRepository
    {
        public ServieNotificationLogRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
