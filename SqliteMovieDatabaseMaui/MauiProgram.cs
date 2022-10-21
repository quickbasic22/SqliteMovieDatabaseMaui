using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SqliteMovieDatabaseMaui.Data;
using SqliteMovieDatabaseMaui.ViewModels;
using SqliteMovieDatabaseMaui.Views;

namespace SqliteMovieDatabaseMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>().UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddSingleton<MovieItemDatabase>();
		builder.Services.AddSingleton<MovieListPage>();
		builder.Services.AddSingleton<MovieListViewModel>();


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
