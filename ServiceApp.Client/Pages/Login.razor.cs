using Microsoft.AspNetCore.Components;
using ServiceApp.Shared.Model;

namespace ServiceApp.Client.Pages
{
    public partial class Login
    {


        private LoginModel loginModel = new LoginModel();
        private bool ShowErrors;
        private string Error = "";

        private async Task HandleLogin()
        {
            ShowErrors = false;

            var result = await AuthService.Login(loginModel);

            if (result.Successful)
            {
                NavigationManager.NavigateTo("/");
            }
            else
            {
                Error = result.Error!;
                ShowErrors = true;
            }
        }

    }
}