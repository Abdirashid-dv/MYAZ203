
namespace WeatherBroadcast
{
    public class WeatherData
    {

        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string City { get; set; } = string.Empty;

        public DateTime Date { get; private set; }
        public string WeatherDescription { get; set; } = string.Empty;

        public WeatherData()
        {
            Date = DateTime.Now;
        }

        public WeatherData(string city, double temperature, double windspeed, double humidity) : this()
        {
            this.City = city;
            this.Temperature = temperature;
            this.WindSpeed = windspeed;
            this.Humidity = humidity;
        }
    }
}