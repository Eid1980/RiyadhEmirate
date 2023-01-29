using System.Xml.Serialization;

namespace Emirates.Core.Application.Dtos
{
    [XmlRoot(ElementName = "NewDataSet")]
    public class ExternalEntityDto
    {
        [XmlElement(ElementName = "Table")]
        public List<EntityTableDto> ExternalEntityTables { get; set; }
    }

    public class EntityTableDto
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

    }
}
