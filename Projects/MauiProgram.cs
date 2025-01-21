using Projects.Repositories.Login;
using Projects.Repositories.Users;
using UraniumUI;
using UraniumUI.Material;

namespace Projects;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()            
            .UseSentry(options =>
			{
				// TODO: Set the Sentry Dsn
				options.Dsn = "https://examplePublicKey@o0.ingest.sentry.io/0";
			})
			.UseMauiCommunityToolkit()
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Montserrat-SemiBold.ttf", "MontserratSemibold");
                fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");

            });
#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<LoginViewModel>();
		builder.Services.AddSingleton<AddUserViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<AddUserPage>();

		builder.Services.AddSingleton<IUserRepository, UserRepository>();
		builder.Services.AddSingleton<ILoginRepository, LoginRepository>();

		return builder.Build();
	}
}
