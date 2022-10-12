
namespace Emirates.Core.Application.Dtos
{
    public class GetNewsSearchListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int NewsTypeId { get; set; }
        public string ImageName { get; set; }
    }
}
