using Projects.Model;
using Projects.Repositories.Login;

namespace Projects.ViewModels
{
    public partial class InformEmailViewModel(ILoginRepository repository) : ObservableObject
    {
        [ObservableProperty]
        string? email;

        [RelayCommand]
        public async Task SendEmail()
        {
            var emailRecovery = new PasswordRecoveryCode
            {
                Email = email
            };

            Preferences.Set("EmailUser", email);

            repository.RequestCode(emailRecovery);

            await Shell.Current.DisplayAlert("", "Se o E-mail Informado Estiver em Nosso Cadastro, Você Receberá Uma Nova Senha de Acesso.", "OK");

            await Shell.Current.GoToAsync("..");
        }
        
    }
}
