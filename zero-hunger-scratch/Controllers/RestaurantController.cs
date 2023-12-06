using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zero_hunger_scratch.Controllers;
using zero_hunger_scratch.Models;

namespace zero_hunger_scratch.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RestaurantDashboard r)
        {
            var db = new zerohungerEntities1();
            db.RestaurantDashboards.Add(r);
            db.SaveChanges();
            return RedirectToAction("RestaurantDashboard", new {id=r.RestaurantDashboardId});
        }
        [HttpGet]
        public ActionResult RestaurantDashboard(int id)
        {
            var db = new zerohungerEntities1();
            var data = db.RestaurantDashboards.Find(id);

                       

            return View(data);
        }
       
        [HttpPost]
        public ActionResult RestaurantDashboard(int id, string SelectFood, TimeSpan ByTime,int Contact)
        {
            var db = new zerohungerEntities1();

           
            var restaurant = db.RestaurantDashboards.Find(id);

          
            restaurant.SelectFood = SelectFood;
            restaurant.ByTime = ByTime;
            restaurant.Contact = Contact;


            db.SaveChanges();

          
            return RedirectToAction("Confirmed");
        }
        public ActionResult Confirmed()
        {
            return View();
        }



    }
}