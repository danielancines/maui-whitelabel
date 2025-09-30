using Maui.WhiteLabelAppTheme.Services;
using Microsoft.Extensions.Logging;

namespace Maui.WhiteLabelAppTheme;

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
                fonts.AddFont("Font-Awesome-Free-Solid-900.otf", "FontAwesomeSolid");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddScoped<MainPage>();
        builder.Services.AddScoped<IVisualService, VisualService>();

        return builder.Build();
    }
}