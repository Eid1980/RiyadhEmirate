
using System.Text.Json.Serialization;

namespace Emirates.Core.Domain.Entities
{
    public class OpenDataReport : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int OpenDataCategueryId { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public virtual OpenDataCateguery OpenDataCateguery { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
