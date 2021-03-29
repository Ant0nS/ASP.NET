using ITMO.ASP.NET.MVC.Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.NET.MVC.Lab1.Controllers
{
    public class MyController : Controller
    {
        private static PersonRepository db = new PersonRepository();
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour; 
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }

        [HttpGet]
        public ViewResult InputData() 
        { 
            return View(); 
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }
        public string Start(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
        public ViewResult OutputData() 
        { 
            ViewBag.Pers = db.GetAllResponses; 
            ViewBag.Count = db.NumberOfPerson; 
            return View("ListPerson"); 
        }
    }
}