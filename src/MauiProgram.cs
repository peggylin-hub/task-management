using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace TaskManagementApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Register services for dependency injection
		RegisterServices(builder.Services);

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	private static void RegisterServices(IServiceCollection services)
	{
		// Views
		services.AddTransient<Views.MainPage>();

		// ViewModels
		// services.AddTransient<ViewModels.MainViewModel>();

		// Services will be registered here as we create them
		// services.AddSingleton<Services.Auth.IAuthService, Services.Auth.AuthService>();
		// services.AddSingleton<Services.Tasks.ITaskService, Services.Tasks.TaskService>();
		// services.AddSingleton<Services.Network.IApiService, Services.Network.ApiService>();
	}
}
