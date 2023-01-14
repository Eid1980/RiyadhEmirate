using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;


namespace Emirates.InfraStructure.Repositories
{
    public class OpenDataReportRepository : Repository<OpenDataReport, EmiratesContext>, IOpenDataReportRepository
    {
        public OpenDataReportRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
