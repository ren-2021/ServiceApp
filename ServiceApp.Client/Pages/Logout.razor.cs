using Microsoft.AspNetCore.Components;

namespace ServiceApp.Client.Pages
{
    public partial class Logout
    {

        protected override async Task OnInitializedAsync()
        {
            await AuthService.Logout();
            NavigationManager.NavigateTo("/");
        }

    }
}