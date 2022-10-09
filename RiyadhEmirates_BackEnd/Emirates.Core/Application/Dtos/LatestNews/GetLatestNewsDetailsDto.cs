
namespace Emirates.Core.Application.Dtos
{
    public class GetLatestNewsDetailsDto : CreateLatestNewsDto
    {
        public int Id { get; set; }
        public string NewsCategueryName { get; set; }
        public string LatestNewsDate { get; set; }
        public UploadedFileBase64Dto Image { get; set; }
    }
}
