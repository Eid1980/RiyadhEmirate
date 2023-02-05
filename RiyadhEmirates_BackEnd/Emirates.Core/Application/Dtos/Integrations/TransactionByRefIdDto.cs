using System.Xml.Serialization;

namespace Emirates.Core.Application.Dtos
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class TransactionByRefIdDto
    {
        [XmlElement(ElementName = "Table")]
        public List<TransactionByRefId> TransactionByRefIds { get; set; }
    }
    public class TransactionByRefId
    {
        [XmlElement(ElementName = "CorrespondanceID")]
        public string CorrespondanceId { get; set; }
    }
}
