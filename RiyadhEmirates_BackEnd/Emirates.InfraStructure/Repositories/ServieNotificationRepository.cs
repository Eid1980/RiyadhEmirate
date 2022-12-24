using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;


namespace Emirates.InfraStructure.Repositories
{
    public class ServieNotificationRepository : Repository<ServieNotification, EmiratesContext>, IServieNotificationRepository
    {
        public ServieNotificationRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
