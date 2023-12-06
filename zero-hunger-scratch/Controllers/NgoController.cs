using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using zero_hunger_scratch.Models;

namespace zero_hunger_scratch.Controllers
{
    public class NgoController : Controller
    {
        private readonly zerohungerEntities1 db = new zerohungerEntities1();

        // GET: Ngo
        public ActionResult NRestaurants()
        {
            List<RestaurantDashboard> restaurants = db.RestaurantDashboards.ToList();
            return View(restaurants);
        }

        [HttpPost]
        public ActionResult NRestaurants(RestaurantNGOEnd e)
        {
            var db = new zerohungerEntities1();

           
            var data = new RestaurantNGOEnd()
            {
              
                RestaurantDashboardId =e.RestaurantDashboardId,
                RestaurantName = e.RestaurantName,
                SelectedFood = e.SelectedFood,
                ByTime = (TimeSpan)e.ByTime,
                Contact = e.Contact,
                RestaurantLocation = e.RestaurantLocation
                
            };

          
            db.RestaurantNGOEnds.Add(data);

        
            db.SaveChanges();

        
            return RedirectToAction("EmpIndex","Employee");
        }

    }

}
