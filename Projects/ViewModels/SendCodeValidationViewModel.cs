using Projects.Model;
using Projects.Repositories.Login;

namespace Projects.ViewModels
{
    public partial class SendCodeValidationViewModel(ILoginRepository repository) : ObservableObject
    {
        [ObservableProperty]
        string? code;

        [RelayCommand]
        public async Task SendCode()
        {
            string userEmail = Preferences.Get("EmailUser", "default");

            var newCodeValidation = new ValidateCode(userEmail, code);

            bool result = await repository.SendCodeValidation(newCodeValidation);

            if (!result)
            {
                await Shell.Current.DisplayAlert("Ops", "Código Inválido, Tente Novamente ou Solicite Novo Código", "OK");

                return;
            }

            await Shell.Current.GoToAsync(nameof(ChangePasswordPage));
        }
    }
}
