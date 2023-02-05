using System.Xml.Serialization;

namespace Emirates.Core.Application.Dtos
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class TransactionResponseDto
    {
        [XmlElement(ElementName = "Table")]
        public List<TransactionResponse> TransactionResponses { get; set; }
    }
    public class TransactionResponse
    {
        [XmlElement(ElementName = "LetterDate")]
        public string LetterDate { get; set; }

        [XmlElement(ElementName = "LetterNo")]
        public string LetterNo { get; set; }

        [XmlElement(ElementName = "StartDate")]
        public string StartDate { get; set; }

        [XmlElement(ElementName = "IntNumber")]
        public string IntNumber { get; set; }

        [XmlElement(ElementName = "ExternalEntity")]
        public string ExternalEntity { get; set; }

        [XmlElement(ElementName = "subExternalEntity")]
        public string SubExternalEntity { get; set; }

        [XmlElement(ElementName = "subSubExternalEntity")]
        public string SubSubExternalEntity { get; set; }

        [XmlElement(ElementName = "state")]
        public int State { get; set; }

        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
    }
}
