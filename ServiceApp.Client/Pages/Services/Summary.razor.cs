using Microsoft.AspNetCore.Components;
using ServiceApp.Client.Services;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared.Model.Services.Airline;
using ServiceApp.Shared.Model.Services.ATMPortable;
using ServiceApp.Shared.Model.Services.DFA;
using ServiceApp.Shared.Model.Services.Financial;
using ServiceApp.Shared.Model.Services.LTO;
using ServiceApp.Shared.Model.Services.Notary;
using ServiceApp.Shared.Model.Services.OtherServices;
using ServiceApp.Shared.Model.Services.PSA;
using ServiceApp.Shared.Model.Services.VISAProcessing;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Summary
    {
        public bool IsSuccess {  get; set; } 
        protected override void OnInitialized()
        {
  
        }

        private async Task SubmitData()
        {
            await this.TransactionService.Process(ClientInfo, Accounting, OtherServices, PSAAssistance, DFAServices, Notary, LTOServices, AirlineServices, VISAProcessing, FinancialServices, ATMPortable);
        }
    }
}