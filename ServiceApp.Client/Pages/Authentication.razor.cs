using Microsoft.AspNetCore.Components;

namespace ServiceApp.Client.Pages
{
    public partial class Authentication
    {
        [Parameter] public string? Action { get; set; }
    }
}