using Microsoft.AspNetCore.Components;
using ServiceApp.Shared.Model;

namespace ServiceApp.Client.Pages.Print
{
    public partial class Print
    {
        [Inject] private ClientInfo? ClientInfo { get; set; } = new ClientInfo();

        private void HandleValidSubmit()
        {
            NavigationManager.NavigateTo("/print2");
        }
    }
}