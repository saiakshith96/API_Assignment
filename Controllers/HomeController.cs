using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API_Assignment.Models;
using API_Assignment.APIHandlerManager;
using System.Web;
//using System.Web.Mvc;

namespace API_Assignment.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Food()
        {
            APIHandler webHandler = new APIHandler();
            Mymodel food = webHandler.GetModel();


            return View(food);
        }

        public ActionResult Food1()
        {
            APIHandler webHandler = new APIHandler();
            Mymodel food = webHandler.GetModel1();


            return View(food);
        }

        public ActionResult Display()
        {


            //return new FilePathResult("~/Home/Display.html","text/html");

            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

/*        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
