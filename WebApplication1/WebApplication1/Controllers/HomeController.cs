using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kekka(int a)
        {

            Class1 bbb = new Class1();

            ViewBag.KeisanKekka = bbb.Tasu(a);

            return View();
        }
    }
}