using Microsoft.AspNetCore.Components;
using MudBlazor;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared;
using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Client.Enum.StaticClass;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Enum;
using ServiceApp.Shared.Model.Services.OtherServices;

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
        private List<string> AccountingServices { get; set; }
        private List<string> OtherService { get; set; }
        private List<string> PSAServices { get; set; }
        private List<string> DFAServices { get; set; }
        private List<string> LTOServices { get; set; }
        private List<string> AirlineServices { get; set; }
        private List<string> VISAProcessingServices { get; set; }
        private List<string> FinancialServices { get; set; }
        private List<string> ATMPortableServices { get; set; }
        public decimal Fee { get; set; }
        private bool IsIncluded { get; set; }

        private Dictionary<string, bool> expandedStates = new Dictionary<string, bool>();

        protected override void OnInitialized()
        {
            this.Services = new List<string>() { MainServices.Accounting, MainServices.OtherServices, MainServices.PSA, MainServices.DFA, MainServices.NOTARY, MainServices.LTO, MainServices.Airline, MainServices.VISA, MainServices.Financial, MainServices.ATMPortable };
            this.AccountingServices = new List<string>() { SubServices.Filingoftaxes, SubServices.BIRRegistration, SubServices.ITRPreparation, SubServices.DTIRegistration, SubServices.SECRegistration, SubServices.BusinessPermit, SubServices.PagIbigRegistration, SubServices.SSSRegistration, SubServices.PhilhealthRegistration, SubServices.BookKeeping };
            this.OtherService = new List<string> { SubServices.TransferofTitle, SubServices.PCABAssistance, SubServices.NBIAssistance, SubServices.Weddingmanagement };
            this.PSAServices = new List<string> { SubServices.Cenomar, SubServices.BirthCertificate, SubServices.MarriageCertificate, SubServices.DeathCertificate};
            this.DFAServices = new List<string> { SubServices.PassportAssistance, SubServices.LostPassport};
            this.LTOServices = new List<string> { SubServices.VehicleRegistration };
            this.AirlineServices = new List<string> { SubServices.Domestic, SubServices.International };
            this.VISAProcessingServices = new List<string> { SubServices.USA, SubServices.CanadaETA, SubServices.CanadaRegualar, SubServices.NewZealand, SubServices.China, SubServices.Japan, SubServices.Australia, SubServices.EuropeanCountries, SubServices.SouthKorea };
            this.FinancialServices = new List<string> { SubServices.GCASH };
            this.ATMPortableServices = new List<string> { SubServices.BankBalanceInquiry, SubServices.Withdrawal };
        }
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

        protected void OnValueChangeHandler()
        {
            ClientInfo.AdditionalInfo = this.multilineReference.Text;
        }
        protected void OnSelectedOptionChanged(string _selectedOption, string _subServices)
        {
            var value = System.Enum.Parse<OwnerType>(_selectedOption);

            if (_subServices == SubServices.Filingoftaxes){Accounting.FilingOfTaxes.OwnerType = value;}

            if (_subServices == SubServices.BIRRegistration){Accounting.BIRRegistration.OwnerType = value;}

            if (_subServices == SubServices.ITRPreparation){Accounting.ITRPreparation.OwnerType = value; }

            if (_subServices == SubServices.DTIRegistration){Accounting.DTIRegistration.OwnerType = value;}

            if (_subServices == SubServices.SECRegistration){Accounting.SECRegistration.OwnerType = value;}

            if (_subServices == SubServices.BusinessPermit){Accounting.BusinessPermit.OwnerType = value;}

            if (_subServices == SubServices.PagIbigRegistration){Accounting.PagIbigRegistration.OwnerType = value;}

            if (_subServices == SubServices.SSSRegistration){Accounting.SSSRegistration.OwnerType = value;}

            if (_subServices == SubServices.PhilhealthRegistration){Accounting.PhilhealthRegistration.OwnerType = value;}

            if (_subServices == SubServices.BookKeeping) { Accounting.Bookkeeping.OwnerType = value; }

            if (_subServices == SubServices.Weddingmanagement) { OtherServices.WeddingManagement.OwnerType = value; }
        }

        protected void HandleCheck(bool _isCheck, string _subServices, string _mainService)
        {
            if(_mainService == MainServices.Accounting)
            {
                if (_subServices == SubServices.Filingoftaxes) { Accounting.FilingOfTaxes.IsIncluded = _isCheck; }

                if (_subServices == SubServices.BIRRegistration) { Accounting.BIRRegistration.IsIncluded = _isCheck; }

                if (_subServices == SubServices.ITRPreparation) { Accounting.ITRPreparation.IsIncluded = _isCheck; }

                if (_subServices == SubServices.DTIRegistration) { Accounting.DTIRegistration.IsIncluded = _isCheck; }

                if (_subServices == SubServices.SECRegistration) { Accounting.SECRegistration.IsIncluded = _isCheck; }

                if (_subServices == SubServices.BusinessPermit) { Accounting.BusinessPermit.IsIncluded = _isCheck; }

                if (_subServices == SubServices.PagIbigRegistration) { Accounting.PagIbigRegistration.IsIncluded = _isCheck; }

                if (_subServices == SubServices.SSSRegistration) { Accounting.SSSRegistration.IsIncluded = _isCheck; }

                if (_subServices == SubServices.PhilhealthRegistration) { Accounting.PhilhealthRegistration.IsIncluded = _isCheck; }

                if (_subServices == SubServices.BookKeeping) { Accounting.Bookkeeping.IsIncluded = _isCheck; }

                if (Accounting.FilingOfTaxes.IsIncluded || Accounting.BIRRegistration.IsIncluded || Accounting.ITRPreparation.IsIncluded || Accounting.DTIRegistration.IsIncluded || Accounting.SECRegistration.IsIncluded || Accounting.BusinessPermit.IsIncluded || Accounting.PagIbigRegistration.IsIncluded || Accounting.SSSRegistration.IsIncluded || Accounting.PhilhealthRegistration.IsIncluded || Accounting.Bookkeeping.IsIncluded)
                {
                    Accounting.IsIncluded = true;
                }
                else { Accounting.IsIncluded = false; }
            }
           else if (_mainService == MainServices.OtherServices) 
           {
                if (_subServices == SubServices.TransferofTitle) { OtherServices.TransferofTitle.IsIncluded = _isCheck; }

                if (_subServices == SubServices.PCABAssistance) { OtherServices.PCABAssistance.IsIncluded = _isCheck; }

                if (_subServices == SubServices.NBIAssistance) { OtherServices.NBIAssistance.IsIncluded = _isCheck; }

                if (_subServices == SubServices.Weddingmanagement) { OtherServices.WeddingManagement.IsIncluded = _isCheck; }

                if (OtherServices.TransferofTitle.IsIncluded || OtherServices.PCABAssistance.IsIncluded || OtherServices.NBIAssistance.IsIncluded || OtherServices.WeddingManagement.IsIncluded )
                {
                    OtherServices.IsIncluded = true;
                }
                else { OtherServices.IsIncluded = false; }
            }
        }
    }
}