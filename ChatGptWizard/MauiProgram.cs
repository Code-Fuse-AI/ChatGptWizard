using ChatGptWizard.Data;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using Microsoft.Extensions.DependencyInjection;
using ChatGptWizard.Service;

namespace ChatGptWizard;

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
			});
        // Set path to the SQLite database (it will be created if it does not exist)
        var dbPath =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"ChatGptWizard.db");
        // Register MessageService and the SQLite database
        builder.Services.AddSingleton<MessageService>(
            s => ActivatorUtilities.CreateInstance<MessageService>(s, dbPath));

        builder.Services.AddScoped<OpenAIApiService>();
        builder.Services.AddScoped(sp => new HttpClient());



        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

