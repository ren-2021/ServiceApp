using Microsoft.AspNetCore.Components;
using MudBlazor;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using static MudBlazor.CategoryTypes;

namespace ServiceApp.Client.Pages.Print
{
    public partial class Print
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public List<string> ColumnNames { get; set; }

        [Parameter]
        public List<object> Items { get; set; }
        private IEnumerable<PrintModel> ServicesInfo = new List<PrintModel>();

        protected override async Task OnInitializedAsync()
        {
            if(this.TransactionInfoContainer.Value != null)
            {
                ServicesInfo = await this.PrintService.GetServicesInfo(this.TransactionInfoContainer.Value.TransactionID);
            }
        }

        private async Task GeneratePDF()
        {
            await this.PrintService.Generate(this.TransactionInfoContainer.Value.TransactionID);
        }
    }
}