using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weather.Online.Models;

namespace Weather.Online.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Weather Application";

            List<Country> listOfCountires = new List<Country> {
                new Country(){ CountryName = "Australia", CountryCode ="AU" },
                new Country(){ CountryName = "India", CountryCode ="IN" },
                new Country(){ CountryName = "Pakistan", CountryCode ="PK" },
                new Country(){ CountryName = "United States", CountryCode ="US" },
                new Country(){ CountryName = "United Kingdom", CountryCode ="UK" },
                new Country(){ CountryName = "Germany", CountryCode ="DE" },
                new Country(){ CountryName = "Switzerland", CountryCode ="H" },
                new Country(){ CountryName = "New Zealand", CountryCode ="NZ" }
            };
            return View(listOfCountires);
        }
    }
}
