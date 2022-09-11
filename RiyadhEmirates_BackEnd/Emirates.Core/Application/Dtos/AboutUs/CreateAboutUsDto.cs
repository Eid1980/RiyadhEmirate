using Emirates.Core.Application.Dtos.MainPoints;

namespace Emirates.Core.Application.Dtos.AboutUs
{
    public class CreateAboutUsDto
    {
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string PageContentType { get; set; }
        public CreateMainPoints[] MainPoints { get; set; }
    }
}
