using Microsoft.Extensions.Logging;

namespace NFTMarketplaceApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Italic.ttf", "OpenSansItalic");
				fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
				fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
				fonts.AddFont("OpenSans-BoldItalic.ttf", "OpenSansBoldItalic");
				fonts.AddFont("OpenSans-ExtraBold.ttf", "OpenSansExtraBold");
				fonts.AddFont("OpenSans_SemiCondensed-ExtraBold.ttf", "OpenSansSemiCondensedExtraBold");
				fonts.AddFont("FontAwesome.ttf", "FontAwesome");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
