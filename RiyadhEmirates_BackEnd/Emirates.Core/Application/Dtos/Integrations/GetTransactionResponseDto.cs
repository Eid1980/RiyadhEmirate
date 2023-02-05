
namespace Emirates.Core.Application.Dtos
{
    public class GetTransactionResponseDto
    {
        public string IncomingNumber { get; set; }
        public string IncomingDate { get; set; }

        public string OutgoingNumber { get; set; }
        public string OutgoingDate { get; set; }

        public string LetterDate { get; set; }
        public string LetterNo { get; set; }

        public string StateName { get; set; }
        public string IncomingEntityName { get; set; }
        public string OutgoingEntityName { get; set; }

        public bool CanFeedback { get; set; } = false;
    }
}
