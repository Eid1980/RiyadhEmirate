using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories.Security
{
    public class UploadedFileRepository : Repository<UploadedFile, EmiratesContext>, IUploadedFileRepository
    {
        public UploadedFileRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
