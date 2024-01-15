using Microsoft.AspNetCore.Components;
using MudBlazor;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared;
using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Client.Enum.StaticClass;
using ServiceApp.Client.Utility;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Transact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TinNumber { get; set; }
        public string Address { get; set; }
        private MudTextField<string> multilineReference;
        private HashSet<ServiceItemData> TreeItems { get; set; } = new HashSet<ServiceItemData>();
        private Accounting? Accounting { get; set; }
        private void OpenDialog()
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<ClientDialog>("Clients", options);
        }

        protected void CheckedChanged(ServiceItemData item)
        {
            this.Accounting = new Accounting();
            item.IsChecked = !item.IsChecked;
            if (item.HasChild)
            {
                foreach (ServiceItemData child in item.TreeItems)
                {
                    child.IsChecked = item.IsChecked;
                }
            }
            if (item.Parent != null)
            {
                item.Parent.IsChecked = !item.Parent.TreeItems.Any(i => !i.IsChecked);
            }

            if (item.HasChild)
            {
                foreach (ServiceItemData child in item.TreeItems)
                {
                    if (child.IsChecked)
                    {
                        if(child.Text == SubServices.Filingoftaxes) {this.Accounting.FilingOfTaxes = new FilingOfTaxes(){};}
                        if (child.Text == SubServices.BIRRegistration) {}
                        if (child.Text == SubServices.ITRPreparation) {}
                        if (child.Text == SubServices.DTIRegistration) {}
                        if (child.Text == SubServices.SECRegistration) {}
                    }
                }
            }
            else
            {

            }

            var i = TreeItems;
        }

        protected override void OnInitialized()
        {
            List<ServiceItemData> treeItems = new List<ServiceItemData>()
            {
                new ServiceItemData(MainServices.Accounting),
                new ServiceItemData(MainServices.OtherServices),
                new ServiceItemData(MainServices.PSA),
                new ServiceItemData(MainServices.DFA),
                new ServiceItemData(MainServices.NOTARY),
                new ServiceItemData(MainServices.LTO),
                new ServiceItemData(MainServices.Airline),
                new ServiceItemData(MainServices.VISA),
                new ServiceItemData(MainServices.Financial),
                new ServiceItemData(MainServices.ATMPortable)
             };

            treeItems[0].AddChild(SubServices.Filingoftaxes);
            treeItems[0].AddChild(SubServices.BIRRegistration);
            treeItems[0].AddChild(SubServices.ITRPreparation);
            treeItems[0].AddChild(SubServices.DTIRegistration);
            treeItems[0].AddChild(SubServices.SECRegistration);
            treeItems[1].AddChild(SubServices.TransferofTitle);
            treeItems[1].AddChild(SubServices.PCABAssistance);
            treeItems[1].AddChild(SubServices.NBIAssistance);
            treeItems[1].AddChild(SubServices.Weddingmanagement);
            treeItems[2].AddChild(SubServices.Cenomar);
            treeItems[2].AddChild(SubServices.BirthCertificate);
            treeItems[2].AddChild(SubServices.MarriageCertificate);
            treeItems[2].AddChild(SubServices.DeathCertificate);
            treeItems[3].AddChild(SubServices.PassportAssistance);
            treeItems[3].AddChild(SubServices.LostPassport);

            foreach(var item in treeItems)
            {
                TreeItems.Add(item);
            }
        }

        private void Proceed()
        {
            NavigationManager.NavigateTo("/summary");
        }
    }
}