using WeatherBroadcast;

public class WeatherForecast
{

    private WeatherData weather;

    public WeatherForecast(string city, double temperature, double windspeed, double humidity)
    {
        weather = SetWeather(city, temperature, windspeed, humidity);
    }


    public WeatherData SetWeather(string city, double temperature, double windspeed, double humidity)
    {
        return new WeatherData(city, temperature, windspeed, humidity);
    }

    public string AutoDescription()
    {
        if (weather.Temperature >= 30 && weather.WindSpeed < 10)
        {
            return "Hot and Calm";
        }
        else if (weather.Temperature >= 20 && weather.WindSpeed >= 10.0)
        {
            return "Hot and Windy";
        }
        else if (weather.Temperature >= 10.0 && weather.WindSpeed < 10)
        {
            return "Pleasant and Calm";
        }
        else if (weather.Temperature <= 0.0)
        {
            return "Snowy and Rainy";

        }
        else
        {
            return "";
        }

    }
    public void GetWeatherForcast()
    {
        weather.WeatherDescription = AutoDescription();
        System.Console.WriteLine(weather.Date + " " + weather.City + " " + weather.WeatherDescription);
    }

}