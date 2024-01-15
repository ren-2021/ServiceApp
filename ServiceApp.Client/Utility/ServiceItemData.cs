namespace ServiceApp.Client.Utility
{
    public class ServiceItemData
    {
        public ServiceItemData Parent { get; set; } = null;

        public string Text { get; set; }

        public bool IsExpanded { get; set; } = false;

        public bool IsChecked { get; set; } = false;

        public bool HasChild => TreeItems != null && TreeItems.Count > 0;

        public HashSet<ServiceItemData> TreeItems { get; set; } = new HashSet<ServiceItemData>();

        public ServiceItemData(string text)
        {
            Text = text;
        }

        public void AddChild(string itemName)
        {
            ServiceItemData item = new ServiceItemData(itemName);
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
