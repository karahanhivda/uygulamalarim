using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiGiriss.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "HavaDurumuTahmini")]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> tahminler = new List<WeatherForecast>();
            for (int index = 1; index <= 5; index++)
            {
                WeatherForecast tahmin = new WeatherForecast();
                tahmin.Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index));
                tahmin.TemperatureC = Random.Shared.Next(-20, 55);
                tahmin.Summary = Summaries[Random.Shared.Next(Summaries.Length)];
                tahminler.Add(tahmin);
            }
            return tahminler;


            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        //[HttpGet(Name = "Selamlama")]
        //public string Karsilama()
        //{
        //    return "Merhaba";
        //}
    }
}
