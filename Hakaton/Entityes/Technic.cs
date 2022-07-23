using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Hakaton.Entityes
{
    [Serializable]
    [XmlRoot]
    public class Technic
    {
        [XmlElement]
        [Key]
        public int Id { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]

        public int Hours;
    }
}
