
namespace Emirates.Core.Application.Dtos
{
    public class GetNewsSearchListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public bool IsLatestNews { get; set; }
        public UploadedFileBase64Dto Image { get; set; }
    }
}
