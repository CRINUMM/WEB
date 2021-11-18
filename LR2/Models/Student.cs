using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LR2.Models
{
    public class Student
    {
        //ID студента
        public int Id { get; set; }
        //Имя студента
        public string Name { get; set; }
        //Группа студента
        public string Group { get; set; }
        //Группа студента
        public int Rating { get; set; }

        /*
        public Student(int i, string n, string g, int r)
        {
            Id = i;
            Name = n;
            Group = g;
            Rating = r;
        }
        */
    }
}