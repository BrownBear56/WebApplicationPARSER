using System;

namespace WebApplicationPARSER.Models
{
    public class User
    {
        public int Id { get; set; } //идентификатор
        public string Surname { get; set; } // фамилия
        public string Name { get; set; } // имя
        public DateTime CreateDate { get; set; } // дата создания
        public DateTime UpdateDate { get; set; } // дата последнего изменения
        public string Status { get; set; } // статус
    }
}