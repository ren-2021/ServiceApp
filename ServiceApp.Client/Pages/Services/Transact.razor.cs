using MudBlazor;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Transact
    {
        public string TextValue { get; set; }
        private MudTextField<string> multilineReference;
        private void OpenDialog()
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<ClientDialog>("Clients", options);
        }
    }
}