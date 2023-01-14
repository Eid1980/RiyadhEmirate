

namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestElectronicSummonDto
    {
        public int RequestTypeId { get; set; }
        public string RequestTitle { get; set; }
        public string RequestContent { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
