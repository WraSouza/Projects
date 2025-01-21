using CommunityToolkit.Maui.Alerts;
using Projects.Model;
using Projects.Repositories.Users;

namespace Projects.ViewModels
{
    public partial class AddUserViewModel(IUserRepository repository) : ObservableObject
    {
        [ObservableProperty]
        string fullName;

        [ObservableProperty]
        string senha;

        [ObservableProperty]
        string email;

        [RelayCommand]
        public async Task AddUserAsync()
        {
            var novoUsuario = new User(FullName, Email, Senha);

            bool response = await repository.AddUserAsync(novoUsuario);

            if (!response)
            {
                var newtoast = Toast.Make("Não Foi Possível Cadastrar o Usuário, Tente Novamente", CommunityToolkit.Maui.Core.ToastDuration.Long);

                await newtoast.Show();

                return;
            }

            var toast = Toast.Make("Usuário Cadastrado Com Sucesso", CommunityToolkit.Maui.Core.ToastDuration.Long);

            await toast.Show();

            await Shell.Current.GoToAsync("..");
        }
    }
}
