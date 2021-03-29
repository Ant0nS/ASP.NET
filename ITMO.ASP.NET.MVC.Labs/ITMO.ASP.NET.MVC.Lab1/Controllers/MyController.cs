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
        // GET: Home
        //public ViewResult Index()
        //{
        //    return View();
        //}
        public string Start(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}