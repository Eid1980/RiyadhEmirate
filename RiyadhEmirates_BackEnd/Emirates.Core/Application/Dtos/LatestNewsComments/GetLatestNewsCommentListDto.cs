

namespace Emirates.Core.Application.Dtos
{
    public class GetLatestNewsCommentListDto
    {
        public string Comment { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string CommentStageName { get; set; }
    }
}
