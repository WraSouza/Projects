namespace Projects.Views;

public partial class SendCodeValidationPage : ContentPage
{
	public SendCodeValidationPage(SendCodeValidationViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}