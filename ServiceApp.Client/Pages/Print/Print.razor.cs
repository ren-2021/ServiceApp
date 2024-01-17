using Microsoft.AspNetCore.Components;
using ServiceApp.Shared.Model;

namespace ServiceApp.Client.Pages.Print
{
    public partial class Print
    {

        private void HandleValidSubmit()
        {
            NavigationManager.NavigateTo("/print2");
        }
    }
}