﻿
namespace Emirates.Core.Application.Dtos
{
    public class GetNationalityListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Code { get; set; }
        public string Iso2 { get; set; }
        public string DialCode { get; set; }
        public bool IsActive { get; set; }
    }
}
