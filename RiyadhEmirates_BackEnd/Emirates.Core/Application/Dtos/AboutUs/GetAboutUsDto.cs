using Emirates.Core.Application.Dtos.MainPoints;

namespace Emirates.Core.Application.Dtos.AboutUs
{
    public class GetAboutUsDto
    {
        public int Id { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public int Order { get; set; }
        public string PageContentType { get; set; }
        public GetMainPagePoints[] MainPoints { get; set; }
    }
}
