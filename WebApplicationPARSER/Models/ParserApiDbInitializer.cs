using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplicationPARSER.Models
{
    public class ParserApiDbInitializer : DropCreateDatabaseAlways<ParserApiDb>
    {     
        protected override void Seed(ParserApiDb db)
        {
            string[] randomSurname = { "Иванченко", "Петренко", "Гренко", "Загагулько", "Перепечко", "Шпон" };
            string[] randomName = { "Анна", "Сергей", "Елена", "Дмитрий", "Александр", "Георгий"
            };
            Random r = new Random();
            string[] surname = {"","","","",""};
            string[] name = { "", "", "", "", ""};
            for (int i = 0; i <= 4; i++)
            {
                surname[i] = randomSurname[r.Next(0, randomSurname.Length - 1)];
            }
            for (int i = 0; i <= 4; i++)
            {
                name[i] = randomName[r.Next(0, randomName.Length - 1)];
            }
            //заполнение генерация пользователей
            db.Users.Add(new User { Id = 1, Surname = surname[0], Name = name[0], CreateDate = DateTime.UtcNow, UpdateDate = DateTime.Now, Status = "blocked" });
            db.Users.Add(new User { Id = 2, Surname = surname[1], Name = name[1], CreateDate = DateTime.UtcNow, UpdateDate = DateTime.Now, Status = "active" });
            db.Users.Add(new User { Id = 3, Surname = surname[2], Name = name[2], CreateDate = DateTime.UtcNow, UpdateDate = DateTime.Now, Status = "disabled" });
            db.Users.Add(new User { Id = 4, Surname = surname[3], Name = name[3], CreateDate = DateTime.UtcNow, UpdateDate = DateTime.Now, Status = "active" });
            db.Users.Add(new User { Id = 4, Surname = surname[4], Name = name[4], CreateDate = DateTime.UtcNow, UpdateDate = DateTime.Now, Status = "blocked" });

            //генерация задач
            db.Tasks.Add(new Task { Id = 1, Title = "Тестовое задание", Description = "Тестовое описание задачи", CreateDate = DateTime.UtcNow, UpdateDate = DateTime.Now, Status = "blocked", Сustomer = 1, Executor = 2 });


            base.Seed(db);
        }
    }
}