
namespace Emirates.Core.Domain.Entities
{
    public class LatestNewsComment
    {
        public int Id { get; set; }
        public int LatestNewsId { get; set; }
        public string Comment { get; set; }
        public int CommentStageId { get; set; }
        public string Email { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual User ModifiedUser { get; set; }
        public LatestNews LatestNews { get; set; }
        public CommentStage CommentStage { get; set; }
    }
}
