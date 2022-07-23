using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Hakaton.Entityes
{
    [Serializable]
    [XmlRoot]
    public class People
    {
        [XmlElement]
        [Key]
        public int Id { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public int Age { get; set; }
        [XmlElement]
        public Spetials Spetial { get; set; }
        [XmlElement]

        public double Rating { get; set; } = 3;
        [XmlElement]

        public int Hours;
    }
}
