namespace Projects.Views;

public partial class DetailsProjectPage : ContentPage
{
	public DetailsProjectPage(DetailsProjectViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}