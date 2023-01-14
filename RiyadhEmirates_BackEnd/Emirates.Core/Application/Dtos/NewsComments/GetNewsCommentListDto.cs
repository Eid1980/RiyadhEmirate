

namespace Emirates.Core.Application.Dtos
{
    public class GetNewsCommentListDto
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string CreatedByName { get; set; }
        public string CreatedDate { get; set; }
        public string CommentStageName { get; set; }
        public bool IsArabic { get; set; }
    }
}
