namespace ServiceApp.Client.Pages.Services
{
    public partial class MainTransact
    {
        public int ActivePanel { get; set; }

        protected void GoToTab(int _tabIndex) => this.ActivePanel = _tabIndex;
    }
}