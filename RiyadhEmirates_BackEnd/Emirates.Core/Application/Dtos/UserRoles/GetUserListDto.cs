﻿
namespace Emirates.Core.Application.Dtos
{
    public class GetUserListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string GovernorateName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsActive { get; set; }
    }
}
