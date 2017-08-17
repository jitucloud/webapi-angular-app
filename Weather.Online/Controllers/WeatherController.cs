using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Weather.Online.Models;

namespace Weather.Online.Controllers
{
    [RoutePrefix("api")]
    public class WeatherController : ApiController
    {
        List<Country> listOfCountires = new List<Country>();
        WeatherController()
        {
            listOfCountires = new List<Country> {
                new Country(){
                    CountryName = "Australia",
                    CountryCode ="AU",
                    CityList = new List<City>{
                        new City(){CityName="Sydney",CityCode= "SYD"},
                        new City(){CityName="Melbourne", CityCode="MEL"},
                        new City(){CityName="Perth",CityCode= "PER"}
                    }},
                new Country(){
                    CountryName = "India",
                    CountryCode ="IN",
                    CityList = new List<City>{
                        new City(){CityName="Delhi",CityCode= "DEL"},
                        new City(){CityName="Bangalore", CityCode="BLR"},
                        new City(){CityName="Hydrebad",CityCode= "HYD"},
                        new City(){CityName="Faridabad",CityCode= "FBD"}

                    }},
                new Country(){
                    CountryName = "Pakistan",
                    CountryCode ="PK",
                    CityList = new List<City>{
                        new City(){CityName="Karachi",CityCode= "KHI"},
                        new City(){CityName="Islamabad", CityCode="ISB"},
                        new City(){CityName="Lahore",CityCode= "LHE"}
                    }},
                new Country(){
                    CountryName = "United States",
                    CountryCode ="US",
                    CityList = new List<City>{
                        new City(){CityName="New York",CityCode= "NYC"},
                        new City(){CityName="Miami", CityCode="MAI"},
                        new City(){CityName="Chicago",CityCode= "ORD"}
                    }},
                new Country(){
                    CountryName = "United Kingdom",
                    CountryCode ="UK",
                    CityList = new List<City>{
                        new City(){CityName="London",CityCode= "LON"},
                        new City(){CityName="Manchester", CityCode="MAN"}
                    }},
                new Country(){
                    CountryName = "Germany",
                    CountryCode ="DE" ,
                    CityList = new List<City>{
                        new City(){CityName="New York",CityCode= "NYC"},
                        new City(){CityName="Miami", CityCode="MAI"},
                        new City(){CityName="Chicago",CityCode= "ORD"}
                    }},
                new Country(){
                    CountryName = "Switzerland",
                    CountryCode ="CH" ,
                    CityList = new List<City>{
                        new City(){CityName="New York",CityCode= "NYC"},
                        new City(){CityName="Miami", CityCode="MAI"},
                        new City(){CityName="Chicago",CityCode= "ORD"}
                    }},
                new Country(){
                    CountryName = "New Zealand",
                    CountryCode ="NZ",
                    CityList = new List<City>{
                        new City(){CityName="New York",CityCode= "NYC"},
                        new City(){CityName="Miami", CityCode="MAI"},
                        new City(){CityName="Chicago",CityCode= "ORD"}
                    }},
            };
        }

        /// <summary>
        /// Get All the countires 
        /// </summary>
        /// <returns>List of countries</returns>
        // GET api/weather/countries
        [Route("weather/countries")]
        [HttpGet]
        public HttpResponseMessage GetAllCountries()
        {
            return Request.CreateResponse(HttpStatusCode.OK, listOfCountires);
        }

        /// <summary>
        /// Get Cities based on Country Code
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        // GET api/weather/countires/{countryCode}
        [Route("weather/countries/{countryCode}")]
        [HttpGet]
        public HttpResponseMessage GetCitiesByCountry(String countryCode)
        {
            Country country = listOfCountires.Where(c => String.Equals(c.CountryCode, countryCode, StringComparison.OrdinalIgnoreCase)).Select(c => c).FirstOrDefault();
            if (country != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, country.CityList);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, String.Format("{0} : {1}", "Response not found for following country",countryCode));
        }

    }
}
