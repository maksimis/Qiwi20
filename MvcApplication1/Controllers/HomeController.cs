using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ZadanController _zadAudlist;
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About(string name)
        {
             _zadAudlist = new ZadanController();


            return View(_zadAudlist.modelAudirov);
        }

        public ActionResult Solve(int id)
        {
            ZadanAudirovModel r = new ZadanAudirovModel();
            _zadAudlist = new ZadanController();
             r = _zadAudlist.modelAudirov.Find(delegate(ZadanAudirovModel bk)
            {
                return bk.ID == id;
            });

            return View(r);
        }

    }
}
