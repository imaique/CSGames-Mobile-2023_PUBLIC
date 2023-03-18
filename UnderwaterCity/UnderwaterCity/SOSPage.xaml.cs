namespace UnderwaterCity;

public partial class SOSPage : ContentPage
{
	public SOSPage(SOSViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
