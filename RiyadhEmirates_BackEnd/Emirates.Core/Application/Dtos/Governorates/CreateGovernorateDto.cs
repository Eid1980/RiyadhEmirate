﻿
namespace Emirates.Core.Application.Dtos
{
    public class CreateGovernorateDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string PhoneNumber { get; set; }
        public string LocationLink { get; set; }
        public string PortalLink { get; set; }
        public bool IsActive { get; set; }
    }
}