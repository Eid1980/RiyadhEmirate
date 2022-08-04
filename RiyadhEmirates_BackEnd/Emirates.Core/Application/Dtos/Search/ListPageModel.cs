using X.PagedList;

namespace Emirates.Core.Application.Dtos.Search
{
    public class ListPageModel<Model>
    {
        public IPagedList PagingMetaData { get; set; }
        public IPagedList<Model> GridItemsVM { get; set; }
    }
}
