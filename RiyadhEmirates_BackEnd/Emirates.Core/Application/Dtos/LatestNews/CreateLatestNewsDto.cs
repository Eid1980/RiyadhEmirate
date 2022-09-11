
namespace Emirates.Core.Application.Dtos
{
    public class CreateLatestNewsDto
    {
        private DateTime date;
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsArabic { get; set; }
        public int NewsCategueryId { get; set; }
        public DateTime Date { get { return date.ToLocalTime(); } set { date = value; } }
        public string NewsOrigin { get; set; }
        public bool IsActive { get; set; }
        public bool OpenComments { get; set; }
    }
}
