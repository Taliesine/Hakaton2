using System.Xml.Serialization;

namespace Hakaton.Entityes
{
    [Serializable]
    [XmlRoot]
    public class Material
    {
        [XmlElement]
        public int Id { get; set; }
        [XmlElement("Works")]
        public string Name { get; set; }

        [XmlElement("Works")]
        public string Unit { get; set; }

        [XmlElement("Works")]
        public int Amount { get; set; }

    }
}
