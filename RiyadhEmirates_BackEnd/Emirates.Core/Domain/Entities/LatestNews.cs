﻿
namespace Emirates.Core.Domain.Entities
{
    public class LatestNews : AuditFullData<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsArabic { get; set; }
        public int NewsCategueryId { get; set; }
        public DateTime Date { get; set; }
        public string NewsOrigin { get; set; }
        public bool IsActive { get; set; }
        public bool OpenComments { get; set; }

        public virtual NewsCateguery NewsCateguery { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<LatestNewsComment> LatestNewsComments { get; set; }
    }
}