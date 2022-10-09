
namespace Emirates.Core.Application.Dtos
{
    public class GetLatestNewsListDto : CreateLatestNewsDto
    {
        public int Id { get; set; }
        public string NewsCategueryName { get; set; }
        public UploadedFileBase64Dto Image { get; set; }
    }
}
