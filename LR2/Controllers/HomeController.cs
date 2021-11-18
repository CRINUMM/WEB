using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LR2.Models;

namespace LR2.Controllers
{
	public class HomeController : Controller
	{
		// создаем контекст данных
		StudentContext db = new StudentContext();
		public ActionResult Index()
		{

			// получаем из бд все объекты Book
			IEnumerable<Student> students = db.Students;
			// передаем все объекты в динамическое свойство Books в ViewBag
			ViewBag.Student = students;
			// возвращаем представление
			return View();
		}

		//----------//UP_OR_DOWN|Start//----------//
		[HttpGet]
		public ActionResult Up_or_Down(int id)
		{
			ViewBag.StudentId = id;
			return View();
		}
		[HttpPost]
		public string Up_or_Down(Change change)
		{
			change.Date = DateTime.Now;
			var s = db.Students.FirstOrDefault(p => p.Id == change.StudentId);
			s.Rating = change.NewRating;
			change.Comment = "Rating change";
			// добавляем информацию о покупке в базу данных
			db.Changes.Add(change);
			// сохраняем в бд все изменения
			db.SaveChanges();
			return change.Name + ", вы успешно внесли изменения в рейтинг студентов";
		}
		//----------//UP_OR_DOWN|End//----------//

		//----------//DELETE|Start//----------//
		[HttpGet]
		public ActionResult Delete(int id)
		{
			ViewBag.StudentId = id;
			return View();
		}
		[HttpPost]
		public string Delete(Change change)
		{
			change.Date = DateTime.Now;
			var s = db.Students.FirstOrDefault(p => p.Id == change.StudentId);
			if (s != null)
			{
				db.Students.Remove(s);
				db.SaveChanges();
			}
			s.Rating = change.NewRating;
			change.Comment = "Delete";
			// добавляем информацию о покупке в базу данных
			db.Changes.Add(change);
			// сохраняем в бд все изменения
			db.SaveChanges();
			return "Вы успешно удалили студента из рейтинга";
		}
		//----------//DELETE|End//----------//

		//----------//ADD|Start//----------//
		[HttpGet]
		public ActionResult Add()
		{
			//ViewBag.StudentId = id;
			return View();
		}
		[HttpPost]
		public string Add(Student student)
		{
			// добавляем информацию о покупке в базу данных
			db.Students.Add(student);
			// сохраняем в бд все изменения
			db.SaveChanges();
			return "Вы успешно добавили студента в рейтинг";
		}
		//----------//ADD|End//----------//

		public ActionResult Delete_or_Add()
		{
			return View();
		}

	}
}