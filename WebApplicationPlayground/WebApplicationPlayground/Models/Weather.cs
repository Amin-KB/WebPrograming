using System.ComponentModel.DataAnnotations;

namespace WebApplicationPlayground.Models
{
    public class Weather
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(45)]
        public string Place { get; set; }

        [Range(10, 45)]
        public int Temperature { get; set; }

        public string Country { get; set; }

        public bool Rain { get; set; }
        public bool Storm { get; set; }

        public bool Tornado { get; set; }

        public string Forcasting()
        {

            if (Rain == true)
            {
                return "Rain";
            }
            if (Storm == true)
            {
                return "Storm";
            }
            if (Tornado == true)
            {
                return "Tornado";
            }
            return "Not given";
        }
    }
}
