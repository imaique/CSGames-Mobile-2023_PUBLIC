using System;
using CommunityToolkit.Mvvm.ComponentModel;
using UnderwaterCity.Services;

namespace UnderwaterCity
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		string waterTempString;

		float water_temp;

		 
		public MainViewModel()
		{
			WaterTempString = get_default();
			fetch_temperatures();
		}

		async void fetch_temperatures()
		{
			WeatherForecast weatherForecast = await UnderwaterServices.GetTemp();
			WaterTempString = "Water temp is: " + weatherForecast.information.ext_water_temp;
        }


        string get_default()
		{
			return "Loading";
		}
	}
}

