using System.ComponentModel.DataAnnotations;

namespace Hakaton.Entityes
{
    public class Work
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        public List<Technic> Technices { get; set; }
        public List<People> Peoples { get; set; }

        public List<Meteo> Meteos { get; set; }

        public List<Material> Materials { get; set; }

        public Work()
        {
            Peoples = new List<People>();
            Technices = new List<Technic>();
            Meteos = new List<Meteo>();
            Materials = new List<Material>();
        }
    }
}
