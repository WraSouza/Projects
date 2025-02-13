namespace Projects.Views;

public partial class AddProjectPage : ContentPage
{
    private readonly AddProjectViewModel _viewModel;

    public AddProjectPage(AddProjectViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = _viewModel = viewModel;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.GetAllUserss();
    }
}