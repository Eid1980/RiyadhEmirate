
namespace Emirates.Core.Domain.Entities
{
    public class LatestNewsComment
    {
        public int Id { get; set; }
        public int LatestNewsId { get; set; }
        public string Comment { get; set; }
        public int CommentStage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public LatestNews LatestNews { get; set; }
    }
}
