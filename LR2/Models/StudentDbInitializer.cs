using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LR2.Models
{
    public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student { Name = "Егор", Group = "19-В-2", Rating = 1 });
            db.Students.Add(new Student { Name = "Женя", Group = "19-В-2", Rating = 2 });
            db.Students.Add(new Student { Name = "Витя", Group = "19-В-2", Rating = 3 });
            db.Students.Add(new Student { Name = "Костя", Group = "19-В-2", Rating = 4 });

            base.Seed(db);
        }
    }
}