using System.Xml.Serialization;

namespace Emirates.Core.Application.Dtos
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class TransactionByIdDto
    {
        [XmlElement(ElementName = "Table")]
        public List<TransactionById> TransactionByIds { get; set; }
    }
    public class TransactionById
    {
        [XmlElement(ElementName = "startdate")]
        public string StartDate { get; set; }

        [XmlElement(ElementName = "IntNumber")]
        public string IntNumber { get; set; }

        [XmlElement(ElementName = "Externalentity")]
        public string ExternalEntity { get; set; }

        [XmlElement(ElementName = "SubExternalentity")]
        public string SubExternalEntity { get; set; }

        [XmlElement(ElementName = "SubSubExternalentity")]
        public string SubSubExternalEntity { get; set; }

        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
    }
}
