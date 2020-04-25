using CovidService.Adapter.Interfaces;
using CovidService.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using CovidService.Helpers;

namespace CovidService.Adapter.Implementation
{
    public class CovidAdapter : ICovidAdapter
    {
        public CovidModel GetCovidData(string id)
        {
            var covidOutput = new CovidModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Constants.COVIDURL);
                if (string.IsNullOrEmpty(id))
                {
                    var response = client.GetStringAsync(Constants.ENDPOINTWORLD).Result;
                    covidOutput.worldModel = JsonSerializer.Deserialize<WorldModel>(response);
                }
                else
                {
                    var response = client.GetStringAsync(Constants.ENDPOINTWORLD + "/" + id).Result;
                    covidOutput.countryModel = JsonSerializer.Deserialize<CountryModel>(response);
                }
            }
            return covidOutput;
        }
    }
}
