using Syncfusion.Maui.Toolkit.Carousel;

namespace Projects.Views;

public partial class ProjectsPage() : ContentPage
{
    private readonly ProjectsPageViewModel _viewModel;  

    public ProjectsPage(ProjectsPageViewModel viewModel) : this()
    {
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.GetAllProjects();
    }
}