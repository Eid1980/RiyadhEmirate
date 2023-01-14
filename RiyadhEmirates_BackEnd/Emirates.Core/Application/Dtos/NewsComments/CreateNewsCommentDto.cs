

namespace Emirates.Core.Application.Dtos
{
    public class CreateNewsCommentDto
    {
        public int NewsId { get; set; }
        public string Comment { get; set; }
        public int CommentStageId { get; set; }
        public string Email { get; set; }
        public string CreatedByName { get; set; }
    }
}
