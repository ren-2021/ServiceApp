using MudBlazor;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Transact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TinNumber { get; set; }
        public string Address { get; set; }
        private MudTextField<string> multilineReference;
        private HashSet<TreeItemData> TreeItems { get; set; } = new HashSet<TreeItemData>();
        private void OpenDialog()
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<ClientDialog>("Clients", options);
        }

        protected void CheckedChanged(TreeItemData item)
        {
            item.IsChecked = !item.IsChecked;
            // checked status on any child items should mirrror this parent item
            if (item.HasChild)
            {
                foreach (TreeItemData child in item.TreeItems)
                {
                    child.IsChecked = item.IsChecked;
                }
            }
            // if there's a parent and all children are checked/unchecked, parent should match
            if (item.Parent != null)
            {
                item.Parent.IsChecked = !item.Parent.TreeItems.Any(i => !i.IsChecked);
            }
        }

        protected override void OnInitialized()
        {
            List<TreeItemData> treeItems = new List<TreeItemData>()
            {
                new TreeItemData("Accounting Services"),
                new TreeItemData("Other Services"),
                new TreeItemData("PSA Assistance"),
                new TreeItemData("DFA Assistance"),
                new TreeItemData("NOTARY"),
                new TreeItemData("LTO Services"),
                new TreeItemData("Airline Services"),
                new TreeItemData("VISA Processing Assistance"),
                new TreeItemData("Financial Services"),
                new TreeItemData("ATM Portable Services")
             };

            treeItems[0].AddChild("Filing of taxes (Monthly, Quarterly, Annually)");
            treeItems[0].AddChild("BIR Registration");
            treeItems[0].AddChild("ITR Preparation");
            treeItems[0].AddChild("DTI Registration");
            treeItems[0].AddChild("SEC Registration");

            treeItems[1].AddChild("Transfer of Title");
            treeItems[1].AddChild("PCAB Assistance");
            treeItems[1].AddChild("NBI Assistance");
            treeItems[1].AddChild("Wedding management (License|Officiant|Filing)");

            treeItems[2].AddChild("Cenomar");
            treeItems[2].AddChild("Birth Certificate");
            treeItems[2].AddChild("Marriage Certificate");
            treeItems[2].AddChild("Death Certificate");

            treeItems[3].AddChild("Passport Assistance");
            treeItems[3].AddChild("Lost Passport");

            foreach(var item in treeItems)
            {
                TreeItems.Add(item);
            }
        }
    }

    public class TreeItemData
    {
        public TreeItemData Parent { get; set; } = null;

        public string Text { get; set; }

        public bool IsExpanded { get; set; } = false;

        public bool IsChecked { get; set; } = false;

        public bool HasChild => TreeItems != null && TreeItems.Count > 0;

        public HashSet<TreeItemData> TreeItems { get; set; } = new HashSet<TreeItemData>();

        public TreeItemData(string text)
        {
            Text = text;
        }

        public void AddChild(string itemName)
        {
            TreeItemData item = new TreeItemData(itemName);
            item.Parent = this;
            this.TreeItems.Add(item);
        }

        public bool HasPartialChildSelection()
        {
            int iChildrenCheckedCount = (from c in TreeItems where c.IsChecked select c).Count();
            return HasChild && iChildrenCheckedCount > 0 && iChildrenCheckedCount < TreeItems.Count();
        }

    }
}