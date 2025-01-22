namespace Projects.Views;

public partial class InformEmailPage : ContentPage
{
	public InformEmailPage(InformEmailViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}