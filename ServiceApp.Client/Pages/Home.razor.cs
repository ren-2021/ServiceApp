using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ServiceApp.Client.Pages
{
    public partial class Home
    {
        [CascadingParameter] private Task<AuthenticationState>? authenticationStateTask { get; set; }
        public bool IsUserAuthorized {  get; set; }
        protected async override Task OnInitializedAsync()
        {
            var authState = await authenticationStateTask;
            this.IsUserAuthorized = authState.User.Identity.IsAuthenticated;
            
        }

    }
}