using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Domain.Entities
{
    public class RequestAttachmentType : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int ServiceId { get; set; }
        public string ExtentionAllowed { get; set; }
        public int? MaxFileSize { get; set; }
        public bool IsRequired { get; set; }
        public bool IsActive { get; set; }

        public virtual Service Service { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
