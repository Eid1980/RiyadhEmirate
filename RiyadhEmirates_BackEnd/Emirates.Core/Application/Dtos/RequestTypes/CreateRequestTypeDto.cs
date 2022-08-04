namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestTypeDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int ServiceId { get; set; }
        public bool IsActive { get; set; }
    }
}
