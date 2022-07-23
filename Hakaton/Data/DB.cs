using Hakaton.Entityes;

using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace Hakaton.Data
{
    [Serializable]
    [XmlRoot(ElementName = "Database")]
    public class DB 
    {
        [XmlArray("Works")]
        [XmlArrayItem("Work")]
        public List<Work> Works { get; set; } = new List<Work>();

        [XmlArray("Peoples")]
        [XmlArrayItem("People")]
        public List<People> Peoples { get; set; } = new List<People>();

        [XmlArray("Technices")]
        [XmlArrayItem("Technice")]
        public List<Technic> Technices { get; set; } = new List<Technic>();
        [XmlArray("Meteos")]
        [XmlArrayItem("Meteo")]
        public List<Meteo> Meteos { get; set; } = new List<Meteo>();

        public DB()
        {

        }

        



    }
}
