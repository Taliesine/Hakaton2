using Hakaton.Entityes;

using Microsoft.EntityFrameworkCore;


namespace Hakaton.Data
{
    public class DB 
    {

        public List<Work> Works { get; set; }

        public List<People> Peoples { get; set; }

        public List<Technic> Technices { get; set; }

        public List<Meteo> Meteos { get; set; }

        public DB()
        {
            Works = new List<Work>();
            Peoples = new List<People>();
            Technices = new List<Technic>();
            Meteos = new List<Meteo>();
            Meteos = new List<Meteo>();
        }



    }
}
