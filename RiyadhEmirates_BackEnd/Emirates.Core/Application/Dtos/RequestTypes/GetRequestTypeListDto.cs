namespace Emirates.Core.Application.Dtos
{
    public class GetRequestTypeListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public bool IsActive { get; set; }
    }
}
