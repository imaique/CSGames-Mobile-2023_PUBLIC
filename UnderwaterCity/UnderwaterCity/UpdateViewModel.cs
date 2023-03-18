using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using UnderwaterCity.Services;

namespace UnderwaterCity
{
    public partial class UpdateViewModel : ObservableObject
    {
        [ObservableProperty]
        string powerLevel = "test";

        [ObservableProperty]
        string news;

        [ObservableProperty]
        string transit;


        public UpdateViewModel()
        {
            powerLevel = get_default();
            fetch_power();
        }

        async void fetch_power()
        {
            PowerLevelJSON power = await UnderwaterServices.GetPowerLevel();
            float powerlvl = power.information.power_levels;
            string powerString = powerlvl > 9000 ? " (over 9000)" : " (under 9000)";
            PowerLevel = "Power Levels is: " + powerlvl + powerString;
        }

        string get_default()
        {
            return "Loading";
        }

        [RelayCommand]
        async Task TapSOS()
        {
            await Shell.Current.GoToAsync(nameof(SOSPage));
        }
    }
}

