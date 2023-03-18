using System;
using CommunityToolkit.Mvvm.ComponentModel;
using UnderwaterCity.Services;

namespace UnderwaterCity
{
	public partial class MainViewModel : ObservableObject
	{
		
		float water_temp;

		 
		public MainViewModel()
		{
			water_temp = 2;
			Console.WriteLine("hello");
			UnderwaterServices.GetTemp();
		}
	}
}

