using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Controllers
{
    public class HomeController : Controller
    {
        private IStudentenRepository studentenRepository;

        public HomeController(IStudentenRepository s)
        {
            studentenRepository = s;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(studentenRepository.FindAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
