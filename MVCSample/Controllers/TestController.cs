using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test        
        public string GetString()
        {
            return "This is Hello from Test Controller";
        }

        public  ActionResult GetView()
        {
            return View("MyView");
       }

        public ActionResult GetSharedView()
        {
            return View("SharedView");
        }
    }
}