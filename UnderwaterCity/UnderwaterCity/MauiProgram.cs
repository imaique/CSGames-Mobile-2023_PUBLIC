using Microsoft.Extensions.Logging;

namespace UnderwaterCity;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("AtlantislnlineGrunge.ttf", "Atlantis");
			});
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<UpdatePage>();
        builder.Services.AddSingleton<UpdateViewModel>();

        builder.Services.AddTransient<SOSViewModel>();
        builder.Services.AddTransient<SOSPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

