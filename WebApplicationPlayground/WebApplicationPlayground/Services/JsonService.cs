using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WebApplicationPlayground.Controllers;
using WebApplicationPlayground.Models;

namespace WebApplicationPlayground.Services
{
    public static class JsonService
    {
        private static string path = "DB.json";
        public static void SaveJSON()
        {

            var weatherData = JsonConvert.SerializeObject(WeatherController.weatherDatas);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(weatherData);
            }

        }
        public static void LoadJSON()
        {
            
           
            string weatherData = null;

            using (StreamReader sw = new StreamReader(path))
            {
                weatherData = sw.ReadToEnd();
            }

            dynamic weatherDataList = JsonConvert.DeserializeObject<List<Weather>>(weatherData);
            WeatherController.weatherDatas = weatherDataList;


        }
    }
}
