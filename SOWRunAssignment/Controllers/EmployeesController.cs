using SOWRunAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOWRunAssignment.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View("Acknowledgement",employee);
        }
    }
}