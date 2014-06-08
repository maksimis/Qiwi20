using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CourseController : Controller
    {
        
        public List<CourseModel> model {get; set;} // = new List<CourseModel>();

        public CourseController()
        {
            model = new List<CourseModel>();
        model.Add(new CourseModel()
            {
                ID = 1,
                Name = "Базовый курс английского языка для начинающих",
                level = "Elementary",
                Price = 0,
                ImageSource = "tourizm.jpeg",
                Description = "Изучение основных конструкций в английском языке: простое прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5,
                Theme = "Туризм"
            });
            model.Add(new CourseModel()
            {
                ID = 2,
                Name = "Продвинутый курс английского языка для начинающих",
                level = "Elementary",
                Price = 10,
                ImageSource = "bizness.jpeg",
                Description = "Изучение продвинытых конструкций в английском языке: совершенное прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5,
                Theme = "Бизнес"
            });
            model.Add(new CourseModel()
            {
                ID = 3,
                Name = "Базовый курс английского языка для начинающих",
                level = "Elementary",
                Price = 0,
                ImageSource = "programm.jpeg",
                Description = "Изучение основных конструкций в английском языке: простое прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5,
                Theme = "Программирование"
            });
        }
        public ActionResult Index()
        {
            return View(model);
        }

        public ActionResult Details (int id) {
            CourseModel r = model.Find(delegate(CourseModel bk)
            {
                return bk.ID == id;
            });

           return View(r);
            
        }

        public ActionResult Buy(int id)
        {
            CourseModel r = model.Find(delegate(CourseModel bk)
            {
                return bk.ID == id;
            });

            return View(r);

        }
    }
}
