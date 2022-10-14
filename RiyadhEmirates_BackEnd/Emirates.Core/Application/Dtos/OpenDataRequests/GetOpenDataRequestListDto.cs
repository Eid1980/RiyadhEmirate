
namespace Emirates.Core.Application.Dtos
{
    public class GetOpenDataRequestListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsReplied { get; set; }
    }
}
