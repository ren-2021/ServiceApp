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

        [Parameter]
        public string? ErrorMessage { get; set; } = "";

        private bool expanded = true;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TinNumber { get; set; }
        public string? Address { get; set; }
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

        private bool isAnySelectionMade = false;

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
         => expandedStates[_service] = expandedStates.ContainsKey(_service) ? !expandedStates[_service] : true;
        private void OpenDialog()
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<ClientDialog>("Clients", options);
        }

        protected void OnValueChangeHandler() => ClientInfo.Address = this.multilineReference.Text;

        protected void OnSelectedOptionChanged(string _selectedOption, string _subServices)
        {
            ProcessType processType;
            OwnerType ownerType;
            if (_subServices == SubServices.PassportAssistance) 
            {
                processType = System.Enum.Parse<ProcessType>(_selectedOption);
                DFA.PassportAssistance.ProcessType = processType; 
            }
            else
            {
                ownerType = System.Enum.Parse<OwnerType>(_selectedOption);
                if (_subServices == SubServices.Filingoftaxes) { Accounting.FilingOfTaxes.OwnerType = ownerType; }
                if (_subServices == SubServices.BIRRegistration) { Accounting.BIRRegistration.OwnerType = ownerType; }
                if (_subServices == SubServices.ITRPreparation) { Accounting.ITRPreparation.OwnerType = ownerType; }
                if (_subServices == SubServices.DTIRegistration) { Accounting.DTIRegistration.OwnerType = ownerType; }
                if (_subServices == SubServices.SECRegistration) { Accounting.SECRegistration.OwnerType = ownerType; }
                if (_subServices == SubServices.BusinessPermit) { Accounting.BusinessPermit.OwnerType = ownerType; }
                if (_subServices == SubServices.PagIbigRegistration) { Accounting.PagIbigRegistration.OwnerType = ownerType; }
                if (_subServices == SubServices.SSSRegistration) { Accounting.SSSRegistration.OwnerType = ownerType; }
                if (_subServices == SubServices.PhilhealthRegistration) { Accounting.PhilhealthRegistration.OwnerType = ownerType; }
                if (_subServices == SubServices.BookKeeping) { Accounting.Bookkeeping.OwnerType = ownerType; }
                if (_subServices == SubServices.Weddingmanagement) { OtherServices.WeddingManagement.OwnerType = ownerType; }
            }
        }

        protected void HandleCheck(bool _isCheck)
        {
            Notary.IsIncluded = _isCheck;
        }

        protected void HandleCheck(bool _isCheck, string _subServices, string _mainService)
        {
            if (_mainService == MainServices.Accounting)
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
            if (_mainService == MainServices.OtherServices)
            {
                if (_subServices == SubServices.TransferofTitle) { OtherServices.TransferofTitle.IsIncluded = _isCheck; }
                if (_subServices == SubServices.PCABAssistance) { OtherServices.PCABAssistance.IsIncluded = _isCheck; }
                if (_subServices == SubServices.NBIAssistance) { OtherServices.NBIAssistance.IsIncluded = _isCheck; }
                if (_subServices == SubServices.Weddingmanagement) { OtherServices.WeddingManagement.IsIncluded = _isCheck; }
                if (OtherServices.TransferofTitle.IsIncluded || OtherServices.PCABAssistance.IsIncluded || OtherServices.NBIAssistance.IsIncluded || OtherServices.WeddingManagement.IsIncluded)
                {
                    OtherServices.IsIncluded = true;
                }
                else { OtherServices.IsIncluded = false; }
            }
            if (_mainService == MainServices.PSA)
            {
                if (_subServices == SubServices.Cenomar) { PSA.Cenomar.IsIncluded = _isCheck; }
                if (_subServices == SubServices.BirthCertificate) { PSA.BirthCertificate.IsIncluded = _isCheck; }
                if (_subServices == SubServices.MarriageCertificate) { PSA.MarriageCertificate.IsIncluded = _isCheck; }
                if (_subServices == SubServices.DeathCertificate) { PSA.DeathCertificate.IsIncluded = _isCheck; }
                if (PSA.Cenomar.IsIncluded || PSA.BirthCertificate.IsIncluded || PSA.MarriageCertificate.IsIncluded || PSA.DeathCertificate.IsIncluded)
                {
                    PSA.IsIncluded = true;
                }
                else { PSA.IsIncluded = false; }
            }
            if (_mainService == MainServices.DFA)
            {
                if (_subServices == SubServices.PassportAssistance) { DFA.PassportAssistance.IsIncluded = _isCheck; }
                if (_subServices == SubServices.LostPassport) { DFA.LossPassport.IsIncluded = _isCheck; }
                if (DFA.PassportAssistance.IsIncluded || DFA.LossPassport.IsIncluded)
                {
                    DFA.IsIncluded = true;
                }
                else { DFA.IsIncluded = false; }
            }
            if (_mainService == MainServices.LTO)
            {
                if (_subServices == SubServices.VehicleRegistration) { LTO.Registration.IsIncluded = _isCheck; }

                if (LTO.Registration.IsIncluded) { LTO.IsIncluded = true; } else { LTO.IsIncluded = false; }
            }
            if (_mainService == MainServices.Airline)
            {
                if (_subServices == SubServices.Domestic) { Airline.Domestic.IsIncluded = _isCheck; }
                if (_subServices == SubServices.International) { Airline.International.IsIncluded = _isCheck; }
                if (Airline.Domestic.IsIncluded || Airline.International.IsIncluded) { Airline.IsIncluded = true; } else { Airline.IsIncluded = false; }
            }
            if (_mainService == MainServices.VISA)
            {
                if (_subServices == SubServices.USA) { VISA.USA.IsIncluded = _isCheck; }
                if (_subServices == SubServices.CanadaETA) { VISA.CanadaETA.IsIncluded = _isCheck; }
                if (_subServices == SubServices.CanadaRegualar) { VISA.CanadaRegular.IsIncluded = _isCheck; }
                if (_subServices == SubServices.NewZealand) { VISA.NewZealand.IsIncluded = _isCheck; }
                if (_subServices == SubServices.China) { VISA.China.IsIncluded = _isCheck; }
                if (_subServices == SubServices.Japan) { VISA.Japan.IsIncluded = _isCheck; }
                if (_subServices == SubServices.Australia) { VISA.Australia.IsIncluded = _isCheck; }
                if (_subServices == SubServices.EuropeanCountries) { VISA.EuropeanCountries.IsIncluded = _isCheck; }
                if (_subServices == SubServices.SouthKorea) { VISA.SouthKorea.IsIncluded = _isCheck; }
                if (VISA.USA.IsIncluded || VISA.CanadaETA.IsIncluded || VISA.CanadaRegular.IsIncluded || VISA.NewZealand.IsIncluded || VISA.China.IsIncluded || VISA.Japan.IsIncluded || VISA.Australia.IsIncluded || VISA.EuropeanCountries.IsIncluded || VISA.SouthKorea.IsIncluded)
                {
                    VISA.IsIncluded = true;
                }
                else { VISA.IsIncluded = false; }
            }
            if (_mainService == MainServices.Financial)
            {
                if (_subServices == SubServices.GCASH) { Financial.GCash.IsIncluded = _isCheck; }
                if (Financial.GCash.IsIncluded) { Financial.IsIncluded = true; } else { Financial.IsIncluded = false; }
            }
            if (_mainService == MainServices.ATMPortable)
            {
                if (_subServices == SubServices.GCASH) { ATMPortable.BankBalanceInquiry.IsIncluded = _isCheck; }
                if (_subServices == SubServices.GCASH) { ATMPortable.Withdrawal.IsIncluded = _isCheck; }
                if (ATMPortable.BankBalanceInquiry.IsIncluded || ATMPortable.Withdrawal.IsIncluded) { ATMPortable.IsIncluded = true; } else { ATMPortable.IsIncluded = false; }
            }
        }
    }
}