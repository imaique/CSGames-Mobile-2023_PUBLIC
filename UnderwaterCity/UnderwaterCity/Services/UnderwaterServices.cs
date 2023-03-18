using System;
using System.Text.Json;

namespace UnderwaterCity.Services
{
	public static class UnderwaterServices
	{
		static HttpClient client;
		static string BaseURL = "http://15.222.250.19";

		static UnderwaterServices()
		{
			client = new HttpClient
			{
				BaseAddress = new Uri(BaseURL)
			};
		}

		public static async Task<WeatherForecast> GetTemp()
		{
			var json = await client.GetStringAsync("temp");
			WeatherForecast weather = JsonSerializer.Deserialize<WeatherForecast>(json);

            Console.WriteLine(weather.information.ext_water_temp);
			return weather;
		}

        public static async Task<AirQuality> GetAirQuality()
        {
            var json = await client.GetStringAsync("air");
            AirQuality airQuality = JsonSerializer.Deserialize<AirQuality>(json);

            Console.WriteLine(airQuality.information.int_air_quality);
            return airQuality;
        }

        public static async Task<WaterQuality> GetWaterQuality()
        {
            var json = await client.GetStringAsync("water");
            WaterQuality waterQuality = JsonSerializer.Deserialize<WaterQuality>(json);
            return waterQuality;
        }

        public static async Task<PowerLevelJSON> GetPowerLevel()
        {
            var json = await client.GetStringAsync("power");
            PowerLevelJSON power = JsonSerializer.Deserialize<PowerLevelJSON>(json);
            return power;
        }
        public static async Task<NewsJSON> GetNews()
        {
            var json = await client.GetStringAsync("news");
            NewsJSON power = JsonSerializer.Deserialize<NewsJSON>(json);
            return power;
        }
        public static async Task<TransitJSON> GetTransit()
        {
            var json = await client.GetStringAsync("transit");
            TransitJSON power = JsonSerializer.Deserialize<TransitJSON>(json);
            return power;
        }


    }
    public class WeatherForecast
    {
        public class WeatherInfo
        {
            public float ext_water_temp { get; set; }
            public float int_temp { get; set; }
        }
        public WeatherInfo information { get; set; }

    }
    public class AirQuality
    {
        public class AirInfo
        {
            public int int_air_quality { get; set; }
        }
        public AirInfo information { get; set; }

    }
    public class WaterQuality
    {
        public class WaterInfo
        {
            public int int_water_quality { get; set; }
        }
        public WaterInfo information { get; set; }

    }

    public class PowerLevelJSON
    {
        public class LevelInfo
        {
            public float power_levels { get; set; }
        }
        public LevelInfo information { get; set; }

    }
    public class NewsJSON
    {
        public class NewsStory
        { 
            public int id { get; set; }
            public string message { get; set; }
            public string title { get; set; }
            public int type { get; set; }
        }
        public IList<NewsStory> news { get; set; }

    }
    public class TransitJSON
    {
        public class TransitItem
        {
            public int id { get; set; }
            public int frequency { get; set; }
            public int line { get; set; }
            public string description { get; set; }
            public string schedule { get; set; }
        }
        public IList<TransitItem> transit { get; set; }

    }
}

