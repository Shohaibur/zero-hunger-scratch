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

            // Create a new instance of the other model
            var data = new RestaurantNGOEnd()
            {
                // Set the properties of the other model with the values from the form
                RestaurantDashboardId =e.RestaurantDashboardId,
                RestaurantName = e.RestaurantName,
                SelectedFood = e.SelectedFood,
                ByTime = (TimeSpan)e.ByTime,
                Contact = e.Contact,
                RestaurantLocation = e.RestaurantLocation
                
            };

            // Add the new instance to the corresponding DbSet
            db.RestaurantNGOEnds.Add(data);

            // Save the changes to the database
            db.SaveChanges();

            // Redirect to the same action or another action as needed
            return RedirectToAction("Index","Home");
        }

    }

}
