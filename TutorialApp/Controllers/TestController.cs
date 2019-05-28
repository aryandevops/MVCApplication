using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialApp.Controllers
{
    public class TestController : Controller
    {
        // Controller would provide User Interaction Logic
        public string MyFirstMethod()
        {
            return "Welcome to Hemant's Website,Wow this is Interesting";
        }

            // Public would automatically make it a ACTION

        public ActionResult MyFirstViewMethod()
        {
            return View("MyFirstView");
        }

   }
}