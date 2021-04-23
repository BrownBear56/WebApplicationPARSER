using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplicationPARSER.Models
{
    public class Task
    {
        public int Id { get; set; } // идентификатор
        public string Title { get; set; } // название
        public string Description { get; set; } // описание
        public DateTime CreateDate { get; set; } // дата создания
        public DateTime UpdateDate { get; set; } // дата последнего оновления
        public string Status { get; set; } // Статус
        public int Сustomer { get; set; } // ID пользователя (заказчик)
        public int Executor { get; set; } // ID пользователя (исполнитель)
    }
}