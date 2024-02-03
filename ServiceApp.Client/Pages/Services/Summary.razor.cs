using Microsoft.AspNetCore.Components;
using MudBlazor;
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
        private bool isVisible;
        [Inject] private IDialogService DialogService { get; set; }
        private bool isProcessing = false;

        protected override void OnInitialized()
        {
            
        }

        private async Task SubmitData()
        {
            bool isSuccess;
            if (isProcessing)
            {
                return;
            }
            try
            {
                OpenOverlay();
                isSuccess = await this.TransactionService.Process(ClientInfo, Accounting, OtherServices, PSAAssistance, DFAServices, Notary, LTOServices, AirlineServices, VISAProcessing, FinancialServices, ATMPortable);
                CloseOverlay();
                OpenSuccessDialog(isSuccess);
            }
            finally
            {
                isProcessing = false;
                CloseOverlay();
            }
        }

        public void OpenOverlay()
        {
            isVisible = true;
        }
        public void CloseOverlay()
        {
            isVisible = false;
        }

        private async void OpenSuccessDialog(bool isSuccess)
        {
            if (isSuccess)
            {
                await DialogService.ShowMessageBox(
                  "Success",
                  "Transaction Info has been process.",
                  yesText: "Okay!", cancelText: "Cancel");
            }
            else
            {
                await DialogService.ShowMessageBox(
                  "Error",
                  "Transaction cannot process right now.",
                  yesText: "Okay!", cancelText: "Cancel");
            }
          
            StateHasChanged();
        }
    }

}