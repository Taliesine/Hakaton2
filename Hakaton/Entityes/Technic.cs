using System.ComponentModel.DataAnnotations;

namespace Hakaton.Entityes
{
    public class Technic
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Hours;
    }
}
