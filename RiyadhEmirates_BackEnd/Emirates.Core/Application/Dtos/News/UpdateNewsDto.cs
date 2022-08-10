

namespace Emirates.Core.Application.Dtos
{
    public class UpdateNewsDto
    {
        private DateTime date;
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public int NewsTypeId { get; set; }
        public DateTime Date { get { return date.ToLocalTime(); } set { date = value; } }
        public bool IsActive { get; set; }
    }
}
