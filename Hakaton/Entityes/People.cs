using System.ComponentModel.DataAnnotations;

namespace Hakaton.Entityes
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Spetials Spetial { get; set; }

        public double Rating { get; set; } = 3;

        public int Hours;
    }
}
