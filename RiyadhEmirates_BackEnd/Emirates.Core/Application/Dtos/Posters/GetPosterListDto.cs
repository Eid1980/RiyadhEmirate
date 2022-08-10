
namespace Emirates.Core.Application.Dtos.Posters
{
    public class GetPosterListDto
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
