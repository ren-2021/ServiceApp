using MudBlazor;
using ServiceApp.Shared.Model.ModelRequest;
using ServiceApp.Shared.Model.Services.VISAProcessing;

namespace ServiceApp.Client.Pages.Services
{
    public partial class MainTransact
    {
        bool success;
        string[] errors = { };
        MudTextField<string> pwField1;
        MudForm form;
        private string ErrorMessage;

        public int ActivePanel { get; set; }

        protected void GoToTab(int _tabIndex) => this.ActivePanel = _tabIndex;

        private async Task Submit()
        {
            await form.Validate();

            if (form.IsValid)
            {
                ValidateInputService();
            }
        }

        private void ValidateInputService()
        {
            if (Accounting.IsIncluded || OtherServices.IsIncluded || PSA.IsIncluded || DFA.IsIncluded || Notary.IsIncluded || LTO.IsIncluded || Airline.IsIncluded || VISA.IsIncluded || Financial.IsIncluded || ATMPortable.IsIncluded)
            {
                ErrorMessage = string.Empty;
                GoToTab(1);
            }
            else
            {
                ErrorMessage = "No selected services. Please select atleast one below.";
            }
        }
    }
}