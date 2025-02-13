namespace Projects;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(AddUserPage), typeof(AddUserPage));
        Routing.RegisterRoute(nameof(InformEmailPage), typeof(InformEmailPage));       
        Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(ProjectsPage), typeof(ProjectsPage));
        Routing.RegisterRoute(nameof(AddProjectPage), typeof(AddProjectPage));
        Routing.RegisterRoute(nameof(DetailsProjectPage), typeof(DetailsProjectPage));



    }
}
