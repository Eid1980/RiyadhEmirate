
namespace Emirates.Core.Application.Dtos
{
    public class CreateAuctionDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
    }
}
