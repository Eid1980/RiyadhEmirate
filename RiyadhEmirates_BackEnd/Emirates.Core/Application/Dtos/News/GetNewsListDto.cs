
namespace Emirates.Core.Application.Dtos
{
    public class GetNewsListDto : CreateNewsDto
    {
        public int Id { get; set; }
        public string NewsCategueryName { get; set; }
    }
}
