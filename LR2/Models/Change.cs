using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LR2.Models
{
    public class Change
    {
        //ID записи
        public int ChangeId { get; set; }
        //ID студента
        public int StudentId { get; set; }
        //Имя изменяющего
        public string Name { get; set; }
        //Новый рейтинг студента
        public int NewRating { get; set; }
        //Время внесения изменений
        public DateTime Date { get; set; }
        //Комментарий
        public string Comment { get; set; }
    }
}
