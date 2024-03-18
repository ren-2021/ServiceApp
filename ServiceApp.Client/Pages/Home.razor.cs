using MudBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ServiceApp.Client.Pages
{
    public partial class Home
    {
        private MudDateRangePicker _picker;
        private DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.AddDays(5).Date);
        private bool _autoClose;
        private int Index = -1;
        private Chart chartValue;
        private string ChartDate;
        int dataSize = 4;
        double[] data = { 77, 25, 20, 5 };
        string[] labels = { "Uranium", "Plutonium", "Thorium", "Caesium", "Technetium", "Promethium",
                        "Polonium", "Astatine", "Radon", "Francium", "Radium", "Actinium", "Protactinium",
                        "Neptunium", "Americium", "Curium", "Berkelium", "Californium", "Einsteinium", "Mudblaznium" };

        Random random = new Random();

        public Home() {
            chartValue = new Chart("Month");
            InitializeDate();
        }

        //public void OndateDateRangeChanged(DateTime? dateRange1, DateTime dateRange2)
        //{
        //    dateRange1 = _dateRange.Start.Value ;
        //    dateRange2 = _dateRange.End.Value;

        //}

        void InitializeDate()
        {
			switch (chartValue.Name)
            {
                case "Month":
                    ChartDate = DateTime.Now.ToString("MMMM dd, yyyy") + " - " + DateTime.Now.AddMonths(1).ToString("MMMM dd, yyyy");
                    break;
                case "Quarterly":
                    ChartDate = DateTime.Now.ToString("MMMM dd, yyyy") + " - " + DateTime.Now.AddMonths(4).ToString("MMMM dd, yyyy");
                    break;
                case "Annually":
                    ChartDate = DateTime.Now.ToString("MMMM dd, yyyy") + " - " + DateTime.Now.AddMonths(12).ToString("MMMM dd, yyyy");
                    break;
                case "Custom":

                    DateTime? dateRange1 = _dateRange.Start.Value.Date;
                    DateTime? dateRange2 = _dateRange.End.Value.Date;

                    string startDate = dateRange1.Value.Date.ToString("MMMM dd, yyyy");
                    string endDate = dateRange2.Value.Date.ToString("MMMM dd, yyyy");

					if (dateRange1 != null && dateRange2 != null)
                    {
                        ChartDate = startDate + " to " +endDate;


                    }
                    //StateHasChanged();

                    break;
                default:
                    break;
            }
        }
    }

    public class Chart
    {
        public Chart(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override bool Equals(object o)
        {
            var other = o as Chart;
            return other?.Name == Name;
        }

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
        public override string ToString() => Name;
    }




}