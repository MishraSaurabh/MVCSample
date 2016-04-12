using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test        
        public string GetString()
        {
            return "This is Hello from Test Controller";
        }

        public ActionResult GetEmployee()
        {
            Employee emp = new Employee();
            emp.FirstName = "Name";
            emp.LastName = "Surname";
            emp.EmployeeID = 100;
            emp.Salary = 4000;
            ViewData["Employee"] = emp;
            return View("Employee");
        }

        public ActionResult GetSharedView()
        {                  
            return View("SharedView");
        }
    }
}