using Microsoft.AspNetCore.Components;
using ServiceApp.Shared.Model;

namespace ServiceApp.Client.Pages
{
    public partial class Register
    {

        private RegisterModel RegisterModel = new RegisterModel();
        private bool ShowErrors;
        private IEnumerable<string>? Errors;

        private async Task HandleRegistration()
        {
            ShowErrors = false;

            var result = await AuthService.Register(RegisterModel);

            if (result.Successful)
            {
                NavigationManager.NavigateTo("/login");
            }
            else
            {
                Errors = result.Errors;
                ShowErrors = true;
            }
        }

    }
}