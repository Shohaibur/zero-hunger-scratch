using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zero_hunger_scratch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmpIndex()
        {
            return View();
        }
    }
}