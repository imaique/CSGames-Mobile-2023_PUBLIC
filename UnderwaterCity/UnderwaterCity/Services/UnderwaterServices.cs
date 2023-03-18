using System;
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

		public static async Task<IEnumerable<String>> GetTemp()
		{
			var json = await client.GetStringAsync("temp");
			Console.WriteLine(json);
			return null;
		}
    }
}

