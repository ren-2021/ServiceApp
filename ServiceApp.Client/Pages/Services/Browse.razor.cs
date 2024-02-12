using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using ServiceApp.Shared.Model;
using System.Net.Http.Json;
using static MudBlazor.CategoryTypes;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Browse
    {
        private IEnumerable<TransactionInfo> Transitions = new List<TransactionInfo>();
        private int selectedRowNumber = -1;
        private MudTable<TransactionInfo> mudTable;
        private List<string> clickedEvents = new();
        private bool IsUserAuthorized { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                Transitions = await this.TransactionService.GetTransactions();
            }
        }

        private void RowClickEvent(TableRowClickEventArgs<TransactionInfo> tableRowClickEventArgs)
        {
            this.TransactionInfoContainer.SetValue(tableRowClickEventArgs.Item);
            NavigationManager.NavigateTo("/print");
        }
    }
}