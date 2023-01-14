
namespace Emirates.Core.Application.Dtos
{
    public class GetNewsDetailsDto : CreateNewsDto
    {
        public int Id { get; set; }
        public string NewsCategueryName { get; set; }
        public string NewsDate { get; set; }
    }
}
