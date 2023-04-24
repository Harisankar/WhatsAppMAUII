namespace WhatsAppMAUI;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
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
			});
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();

        builder.Services
                .AddSingleton<ViewModels.CallsViewModel>();
        builder.Services
                .AddSingleton<ViewModels.StatusViewModel>();

        return builder.Build();
	}
}
