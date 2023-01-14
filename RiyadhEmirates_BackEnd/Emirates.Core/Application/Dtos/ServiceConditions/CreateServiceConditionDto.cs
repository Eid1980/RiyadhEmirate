
namespace Emirates.Core.Application.Dtos
{
    public class CreateServiceConditionDto
    {
        public int ServiceId { get; set; }
        public string Condition { get; set; }
        public int Order { get; set; }
    }
}
