using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zero_hunger_scratch.Models;

namespace zero_hunger_scratch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmpIndex()
        {
            var db = new zerohungerEntities1();
            var data = db.Employees.ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult EmpIndex(Employee e)
        {
            var db = new zerohungerEntities1();

            var data = new Employee()
            {

                EmployeeName = e.EmployeeName,
                RestaurantName = e.RestaurantName,
                AssignTime = e.AssignTime,
                Location = e.Location,
                Status = e.Status,


            };
            db.Employees.Add(data);
            db.SaveChanges();
            return RedirectToAction("EmpAssigned");
        }
        public ActionResult EmpAssigned()
        {
            var db = new zerohungerEntities1();
            var employees = db.Employees.ToList();
            return View(employees);
        }
    }
    
}