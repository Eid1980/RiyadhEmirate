using Emirates.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace Emirates.Core.Application.Dtos
{
    public class CreateServiceDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string SectorAr { get; set; }
        public string SectorEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string RequestLink { get; set; }
        public int? WorkDays { get; set; }
        public bool IsActive { get; set; }
    }
}
