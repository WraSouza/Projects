using Projects.Model;
using Projects.Repositories.Login;

namespace Projects.ViewModels
{
    public partial class LoginViewModel(ILoginRepository repository) : ObservableObject
    {
        [ObservableProperty]
        string email;

        [ObservableProperty]
        string senha;

        [RelayCommand]
        public async Task GoToAddUserlPage()
     => await Shell.Current.GoToAsync(nameof(AddUserPage));

        [RelayCommand]
        public async Task GoToInformEmailPage()
    => await Shell.Current.GoToAsync(nameof(InformEmailPage));

        [RelayCommand]
        public async Task Login()
        {
            LoginRequest login = new LoginRequest(email, senha);

            var token = await repository.LoginAsync(login);

            if (token is null)
            {
                await Shell.Current.DisplayAlert("", "Dados Informados Incorretos", "OK");

                return;
            }

            await Shell.Current.GoToAsync(nameof(MainPage));

        }
    }
}
