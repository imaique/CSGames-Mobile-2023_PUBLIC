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
}

