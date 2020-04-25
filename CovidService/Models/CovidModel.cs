using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidService.Models
{
    public class CovidModel
    {
        public WorldModel worldModel { get; set; }
        public CountryModel countryModel { get; set; }
    }
}
