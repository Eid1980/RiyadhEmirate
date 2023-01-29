using System.Xml.Serialization;

namespace Emirates.Core.Application.Dtos
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class LetterAdvancedSearchResponseDto
    {
        [XmlElement(ElementName = "Table")]
        public List<LetterAdvancedSearchResponse> LetterAdvancedSearchResponses { get; set; }
    }
    public class LetterAdvancedSearchResponse
    {
        [XmlElement(ElementName = "LetterNo")]
        public string LetterNo { get; set; }

        [XmlElement(ElementName = "LetterDate")]
        public string LetterDate { get; set; }

        [XmlElement(ElementName = "ExternalEntity")]
        public string ExternalEntity { get; set; }

        [XmlElement(ElementName = "SubExternalEntity")]
        public string SubExternalEntity { get; set; }

        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }

    }
}
