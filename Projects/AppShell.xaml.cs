namespace Projects;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(AddUserPage), typeof(AddUserPage));
        Routing.RegisterRoute(nameof(InformEmailPage), typeof(InformEmailPage));
        Routing.RegisterRoute(nameof(SendCodeValidationPage), typeof(SendCodeValidationPage));


    }
}
