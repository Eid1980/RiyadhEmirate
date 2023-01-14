
using System.Text.Json.Serialization;

namespace Emirates.Core.Domain.Entities
{
    public class MainPagePoints : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int Order { get; set; }
        public int PageContentId { get; set; }

        [JsonIgnore]
        public virtual PageContent PageContent { get; set; }
    }
}
