using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnderwaterCity
{
	public partial class SOSViewModel: ObservableObject
    {
		[ObservableProperty]
		string name;

        [ObservableProperty]
        string location;

        public SOSViewModel()
		{

		}
	}
}

