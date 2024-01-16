using Microsoft.AspNetCore.Components;
using MudBlazor;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared;
using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Client.Enum.StaticClass;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Enum;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Transact
    {
        private bool expanded = true;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TinNumber { get; set; }
        public string? Address { get; set; }
        public int ActivePanel { get; set; }
        public decimal Amount { get; set; }
        private MudTextField<string>? multilineReference;
        private HashSet<ServiceItemData> TreeItems { get; set; } = new HashSet<ServiceItemData>();
        private Accounting? Accounting { get; set; }
        List<string> Services { get; set; }

        private Dictionary<string, bool> expandedStates = new Dictionary<string, bool>();

        private void OnExpandCollapseClick(string service)
        {
            if (expandedStates.ContainsKey(service))
            {
                expandedStates[service] = !expandedStates[service];
            }
            else
            {
                expandedStates.Add(service, true);
            }
        }
        private void OpenDialog()
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<ClientDialog>("Clients", options);
        }

        protected void GoToTab(int tabIndex)
        {
            this.ActivePanel = tabIndex;
        }

        protected override void OnInitialized()
        {
            this.Services = new List<string>()
            {
                MainServices.Accounting,
                MainServices.OtherServices,
                MainServices.PSA,
                MainServices.DFA,
                MainServices.NOTARY,
                MainServices.LTO,
                MainServices.Airline,
                MainServices.VISA,
                MainServices.Financial,
                MainServices.ATMPortable
            };
        }
    }
}