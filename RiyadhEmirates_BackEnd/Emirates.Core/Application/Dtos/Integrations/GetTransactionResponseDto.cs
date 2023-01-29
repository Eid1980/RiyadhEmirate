
using System.Xml.Serialization;

namespace Emirates.Core.Application.Dtos
{
    [XmlRoot( ElementName = "Table", DataType = "string", IsNullable = true)]
    public class GetTransactionResponseDto
    {
        public string LetterDate { get; set; }
        public string LetterNo { get; set; }
        public string StartDate { get; set; }
        public int IntNumber { get; set; }
        public short ExternalEntity { get; set; }
        public short subExternalEntity { get; set; }
        public int state { get; set; }
        public int id { get; set; }
    }
}
