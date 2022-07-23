using Hakaton.Data;
using Hakaton.Entityes;

namespace Hakaton.Services
{
    public class DBService
    {
        public DB DataBase { get; set; } 

        public DBService()
        {
            DataBase = new DB();

            People p1 = new People();
            p1.Name = "Иванов Иван Иванович";
            p1.Age = 30;
            p1.Spetial = Spetials.Сварщик;
            p1.Rating = 3.5;
            p1.Hours = 80;

            People p2 = new People();
            p2.Name = "Петров Петр Петрович";
            p2.Age = 30;
            p2.Spetial = Spetials.Сварщик;
            p2.Rating = 3.5;
            p2.Hours = 80;

            People p3 = new People();
            p3.Name = "Сидоров Сидор Сидорович";
            p3.Age = 30;
            p3.Spetial = Spetials.Каменщик;
            p3.Rating = 3.5;
            p3.Hours = 160;

            People p4 = new People();
            p4.Name = "Медведев Дмитрий Анатольевич";
            p4.Age = 30;
            p4.Spetial = Spetials.Разнорабочий;
            p4.Rating = 3.5;
            p4.Hours = 240;

            People p5 = new People();
            p5.Name = "Алексеев Алексей Юрьевич";
            p5.Age = 30;
            p5.Spetial = Spetials.Разнорабочий;
            p5.Rating = 3.5;
            p5.Hours = 240;

            DataBase.Peoples.Add(p1);
            DataBase.Peoples.Add(p2);
            DataBase.Peoples.Add(p3);
            DataBase.Peoples.Add(p4);
            DataBase.Peoples.Add(p5);


        }

        #region People
        public async Task<List<People>> GetAllPeoples()
        {
            return DataBase.Peoples;
        }


        public async Task<bool> InsertPeople(People employee)
        {
            DataBase.Peoples.Add(employee);
 
            return true;
        }


        public async Task<People> GetPeople(int Id)
        {
            People employee = DataBase.Peoples.FirstOrDefault(c => c.Id.Equals(Id));
            return employee;
        }

        #endregion


        #region work

        public async Task<List<Work>> GetAllWorks()
        {
            return DataBase.Works;
        }


        public async Task<bool> InsertWork(Work work)
        {
             DataBase.Works.Add(work);

            return true;
        }

        public async Task<Work> GetWorkAsync(int Id)
        {
            Work work =  DataBase.Works.FirstOrDefault(c => c.Id.Equals(Id));
            return work;
        }

        #endregion
    }
}
