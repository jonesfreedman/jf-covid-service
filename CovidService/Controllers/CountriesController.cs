using CovidService.Adapter.Implementation;
using CovidService.Adapter.Interfaces;
using CovidService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CovidService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        // GET: api/Countries
        [HttpGet]
        public WorldModel GetWorldData()
        {
            ICovidAdapter covidAdapter = new CovidAdapter();
            return covidAdapter.GetCovidData("").worldModel;
        }

        // GET: api/Countries/5
        [HttpGet("{id}", Name = "Get")]
        public CountryModel GetCountryData(string id)
        {
            ICovidAdapter covidAdapter = new CovidAdapter();
            return covidAdapter.GetCovidData(id).countryModel;
        }
    }
}
