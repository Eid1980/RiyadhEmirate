
namespace Emirates.Core.Application.Dtos
{
    public class GetLatestNewsCommentDetailsDto
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string CommentStageName { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
    }
}
