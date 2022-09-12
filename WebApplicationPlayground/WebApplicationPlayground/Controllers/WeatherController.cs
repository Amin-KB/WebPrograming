using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationPlayground.Models;

namespace WebApplicationPlayground.Controllers
{
    public class WeatherController : Controller
    {
        public static List<Weather>weatherDatas=new List<Weather>();    
        public IActionResult Index()
        {
            Services.JsonService.LoadJSON();
            return View(weatherDatas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Weather weather)
        {
            Services.JsonService.LoadJSON();
            if (!ModelState.IsValid)
            {
                return View();
            }
            weather.Id = weatherDatas.Count + 1;
            weatherDatas.Add(weather);
            Services.JsonService.SaveJSON();
            return View();
        }
    }
}
