using Hakaton.Data;
using Hakaton.Entityes;
using System.Text.Json;
using System.Xml.Serialization;

namespace Hakaton.Services
{
    public class DBService
    {
        public DB DataBase { get; set; } 

        public DBService()
        {
            Load();

            //DataBase = new DB();
            if (DataBase != null && DataBase.Peoples.Count == 0)
            {


                People p1 = new People();
                p1.Name = "Иванов Иван Иванович";
                p1.Age = 26;
                p1.Spetial = Spetials.Сварщик;
                p1.Rating = 4.71;
                p1.Hours = 80;

                People p2 = new People();
                p2.Name = "Петров Петр Петрович";
                p2.Age = 35;
                p2.Spetial = Spetials.Сварщик;
                p2.Rating = 3.5;
                p2.Hours = 80;

                People p3 = new People();
                p3.Name = "Сидоров Сидор Сидорович";
                p3.Age = 41;
                p3.Spetial = Spetials.Каменщик;
                p3.Rating = 4.27;
                p3.Hours = 160;

                People p4 = new People();
                p4.Name = "Медведев Дмитрий Анатольевич";
                p4.Age = 39;
                p4.Spetial = Spetials.Разнорабочий;
                p4.Rating = 1.2;
                p4.Hours = 240;

                People p5 = new People();
                p5.Name = "Алексеев Алексей Юрьевич";
                p5.Age = 28;
                p5.Spetial = Spetials.Разнорабочий;
                p5.Rating = 4.9;
                p5.Hours = 240;

                DataBase.Peoples.Add(p1);
                DataBase.Peoples.Add(p2);
                DataBase.Peoples.Add(p3);
                DataBase.Peoples.Add(p4);
                DataBase.Peoples.Add(p5);
                Save();
            }

        }

        ~DBService()
        {
            Save();
        }


        /// <summary>
        /// Сохранение сериализованного объекта в файл
        /// </summary>
        /// <param name="FilePath">Путь к файлу с указанием имени</param>
        /// <param name="Obj">Объект для сериализации</param>
        /// <param name="NeedBackup">Нужен ли бэкап</param>
        /// <returns></returns>
        public void Save()
        {
            try
            {
                // сохранение данных
                using (FileStream fs = new FileStream("db.json", FileMode.OpenOrCreate))
                {

                    JsonSerializer.SerializeAsync<DB>(fs, DataBase);
                }
            }
            catch (Exception ex)
            {
                string mees = ex.Message;
            }
        }

        /// <summary>
        /// Восстановить объект из сериализованного состояния
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DB DeSerialize()
        {
            try
            {
                DB? obj = null;

                if (File.Exists("db.json"))
                {
                    using (FileStream fs = new FileStream("db.json", FileMode.OpenOrCreate))
                    {
                        obj = JsonSerializer.Deserialize<DB>(fs);
                    }

                }
                else
                {
                    return null;
                }
                
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        void Load()
        {
            DataBase = DeSerialize();
            if (DataBase==null)
            {
                DataBase = new DB();
            }
        }



        #region People
        public async Task<List<People>> GetAllPeoples()
        {
            return DataBase.Peoples;
        }


        public async Task<bool> InsertPeople(People employee)
        {
            DataBase.Peoples.Add(employee);
            Save();
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
            Save();
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
