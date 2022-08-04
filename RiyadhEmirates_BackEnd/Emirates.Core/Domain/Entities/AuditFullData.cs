using System;

namespace Emirates.Core.Domain.Entities
{
    public class AuditFullData<T> : AuditCreation<T>
    {
        public Guid ConcurrencyStamp { get; set; } = Guid.NewGuid();
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
