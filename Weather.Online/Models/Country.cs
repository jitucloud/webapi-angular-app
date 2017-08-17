using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.Online.Models
{
    public class Country
    {
        public String CountryName { get; set; }
        public String CountryCode { get; set; }
        public List<City> CityList { get; set; }
    }
}