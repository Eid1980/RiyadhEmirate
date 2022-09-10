using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class PageContentRepository : Repository<PageContent, EmiratesContext>, IPageContentRepository
    {
        public PageContentRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
