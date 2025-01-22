namespace Projects.ViewModels
{
    public partial class InformEmailViewModel : ObservableObject
    {
        [ObservableProperty]
        string email;

        [RelayCommand]
        public async Task SendEmail()
        {

        }
    }
}
