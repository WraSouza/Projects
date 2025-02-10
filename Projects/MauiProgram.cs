using DevExpress.Maui;
using Projects.Repositories.Login;
using Projects.Repositories.Projects;
using Projects.Repositories.Users;
using Syncfusion.Maui.Toolkit.Hosting;
using UraniumUI;

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
            .UseDevExpress(useLocalization: false)
            .UseDevExpressCollectionView()
            .ConfigureSyncfusionToolkit()
            .UseUraniumUIMaterial()
            .UseDevExpress()
            .UseDevExpressCharts()
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
        builder.Services.AddSingleton<InformEmailViewModel>();
        builder.Services.AddSingleton<ProfileViewModel>();
        builder.Services.AddSingleton<ProjectsPageViewModel>();


        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<AddUserPage>();
        builder.Services.AddSingleton<InformEmailPage>();
        builder.Services.AddSingleton<ProfilePage>();
        builder.Services.AddSingleton<ProjectsPage>();


        builder.Services.AddSingleton<IUserRepository, UserRepository>();
        builder.Services.AddSingleton<ILoginRepository, LoginRepository>();
        builder.Services.AddSingleton<IProjectRepository, ProjectRepository>();


        return builder.Build();
    }
}
