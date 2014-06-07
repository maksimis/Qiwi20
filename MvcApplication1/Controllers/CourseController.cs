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
        //
        // GET: /Artists/

        public ActionResult Index()
        {
            var model = new List<CourseModel>();
            model.Add(new CourseModel()
            {
                ID = 1,
                Name = "Базовый курс английского языка для начинающих",
                level = "Elementary",
                Price = 0,
                ImageSource = "0.jpg",
                Description = "Изучение основных конструкций в английском языке: простое прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5
            });
            model.Add(new CourseModel()
            {
                ID = 1,
                Name = "Продвинутый курс английского языка для начинающих",
                level = "Elementary",
                Price = 10,
                ImageSource = "0.jpg",
                Description = "Изучение продвинытых конструкций в английском языке: совершенное прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5
            });
            model.Add(new CourseModel()
            {
                ID = 1,
                Name = "Базовый курс английского языка для начинающих",
                level = "Elementary",
                Price = 0,
                ImageSource = "0.jpg",
                Description = "Изучение основных конструкций в английском языке: простое прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5
            });

            return View(model);
        }

        public ActionResult Details (int id) {
            var model = new CourseModel()
            {
                ID = 1,
                Name = "Базовый курс английского языка для начинающих",
                level = "Elementary",
                Price = 0,
                ImageSource = "0.jpg",
                Description = "Изучение основных конструкций в английском языке: простое прошедшее, настоящее, будущее время",
                autor = "Макс",
                autorID = 1,
                rating = 5
            };
        return View(model);
        }
    }
}
