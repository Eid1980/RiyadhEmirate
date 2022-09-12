

namespace Emirates.Core.Application.Dtos
{
    public class CreateLatestNewsCommentDto
    {
        public int LatestNewsId { get; set; }
        public string Comment { get; set; }
        public int CommentStageId { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
    }
}
