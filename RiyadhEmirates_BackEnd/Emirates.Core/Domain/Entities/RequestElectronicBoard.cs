

namespace Emirates.Core.Domain.Entities
{
    public class RequestElectronicBoard
    {
        public Guid Id { get; set; }
        public int RequestTypeId { get; set; }
        public string RequestTitle { get; set; }
        public string RequestContent { get; set; }

        public virtual Request Request { get; set; }
        public virtual RequestType RequestType { get; set; }
    }
}
