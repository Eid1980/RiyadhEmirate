﻿
namespace Emirates.Core.Application.Dtos
{
    public class GetNewsCategueryDetailsDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; }
    }
}