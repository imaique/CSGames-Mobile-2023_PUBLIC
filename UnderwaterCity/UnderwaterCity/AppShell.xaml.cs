namespace UnderwaterCity;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(UpdatePage), typeof(UpdatePage));
	}
}

