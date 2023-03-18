using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using UnderwaterCity.Services;

namespace UnderwaterCity
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		string externalWaterTemp;

        [ObservableProperty]
        string internalTemp;

        [ObservableProperty]
        string airQualityStr;

        [ObservableProperty]
        string waterQualityStr;


        public MainViewModel()
		{
            ExternalWaterTemp = get_default();
            InternalTemp = get_default();
            AirQualityStr = get_default();
            WaterQualityStr = get_default();
            fetch_temperatures();
            fetch_air_qual();
            fetch_water_qual();
		}

		async void fetch_temperatures()
		{
			WeatherForecast weatherForecast = await UnderwaterServices.GetTemp();
            ExternalWaterTemp = "Water temp is: " + weatherForecast.information.ext_water_temp;
            InternalTemp = "City Ambient Temperature: " + weatherForecast.information.int_temp;
        }

        async void fetch_air_qual()
        {
            AirQuality airQuality = await UnderwaterServices.GetAirQuality();
            AirQualityStr = "Air Quality: " + airQuality.information.int_air_quality;
        }
        async void fetch_water_qual()
        {
            WaterQuality waterQuality = await UnderwaterServices.GetWaterQuality();
            WaterQualityStr = "Water Quality: " + waterQuality.information.int_water_quality;
        }

        [RelayCommand]
        async Task OnSwipe()
        {
            await Shell.Current.GoToAsync(nameof(UpdatePage));
        }

        [RelayCommand]
        async Task TapSOS()
        {
            await Shell.Current.GoToAsync(nameof(SOSPage));
        }

        string get_default()
		{
			return "Loading";
		}
	}
}

