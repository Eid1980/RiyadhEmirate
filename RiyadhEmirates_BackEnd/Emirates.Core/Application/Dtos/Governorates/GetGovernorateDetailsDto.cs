﻿
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetGovernorateDetailsDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string PhoneNumber { get; set; }
        public string LocationLink { get; set; }
        public string PortalLink { get; set; }
        public bool IsActive { get; set; }

        public UploadedFileBase64Model Image { get; set; }
    }
}