using System.ComponentModel.DataAnnotations;

namespace Hakaton.Entityes
{
    public class Meteo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
