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
        private MudTextField<string> multilineReference;
        private HashSet<ServiceItemData> TreeItems { get; set; } = new HashSet<ServiceItemData>();
        private List<string> Services { get; set; }
        public decimal Fee { get; set; }
        private bool IsIncluded {  get; set; }

        private Dictionary<string, bool> expandedStates = new Dictionary<string, bool>();

        private void OnExpandCollapseClick(string _service)
        {
            if (expandedStates.ContainsKey(_service))
            {
                expandedStates[_service] = !expandedStates[_service];
            }
            else
            {
                expandedStates.Add(_service, true);
            }
        }
        private void OpenDialog()
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<ClientDialog>("Clients", options);
        }

        protected void GoToTab(int _tabIndex)
        {
            this.ActivePanel = _tabIndex;
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

        protected void OnValueChangeHandler()
        {
            ClientInfo.AdditionalInfo = this.multilineReference.Text;
        }
        protected void OnSelectedOptionChanged(string _selectedOption, string _subServices)
        {
            if(_subServices == SubServices.Filingoftaxes)
            {
                Accounting.FilingOfTaxes.OwnerType = System.Enum.Parse<OwnerType>(_selectedOption);
            }
            
        }

        protected void HandleCheck(bool _isCheck, string _subServices)
        {
            if (_subServices == SubServices.Filingoftaxes)
            {
                Accounting.FilingOfTaxes.IsIncluded = _isCheck;
            }
                
        }
    }
}