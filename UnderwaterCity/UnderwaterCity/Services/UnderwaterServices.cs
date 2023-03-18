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
            var json = await client.GetStringAsync("air");
            WaterQuality waterQuality = JsonSerializer.Deserialize<WaterQuality>(json);

            Console.WriteLine(waterQuality.information.int_water_quality);
            return waterQuality;
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


}

