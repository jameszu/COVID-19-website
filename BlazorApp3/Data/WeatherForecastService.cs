
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BlazorApp3.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]>  GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            //Coordinate cd = Geocode.GetCoordinates("auckland");

            string C19Cases = HttpClientAPI.HttpGet("https://nzcovid19api.xerra.nz/cases/json");

             dynamic m = HttpClientAPI.ToObject<dynamic>(C19Cases);


            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());

        }

    }


}
