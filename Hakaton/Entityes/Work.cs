using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Hakaton.Entityes
{
    [Serializable]

    public class Work
    {
        [XmlElement]
        [Key]
        public int Id { get; set; }
        [XmlElement]
        public string Name { get; set; } = "";
        [XmlElement]
        public string Description { get; set; } = "";
        [XmlElement]

        public List<Technic> Technices { get; set; } = new List<Technic>();
        [XmlElement]
        public List<People> Peoples { get; set; } = new List<People>();
        [XmlElement]

        public List<Meteo> Meteos { get; set; } = new List<Meteo>();
        [XmlElement]

        public List<Material> Materials { get; set; } = new List<Material>();

        public Work()
        {

        }
    }
}
