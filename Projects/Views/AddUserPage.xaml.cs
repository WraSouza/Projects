namespace Projects.Views;

public partial class AddUserPage : ContentPage
{
	public AddUserPage(AddUserViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}