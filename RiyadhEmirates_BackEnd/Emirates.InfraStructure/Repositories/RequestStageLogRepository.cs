using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestStageLogRepository : Repository<RequestStageLog, EmiratesContext>, IRequestStageLogRepository
    {
        public RequestStageLogRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
