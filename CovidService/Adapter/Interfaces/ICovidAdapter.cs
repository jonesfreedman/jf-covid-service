using CovidService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidService.Adapter.Interfaces
{
    interface ICovidAdapter
    {
        public CovidModel GetCovidData(string id);
    }
}
