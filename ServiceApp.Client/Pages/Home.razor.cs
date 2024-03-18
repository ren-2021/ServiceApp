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
        EventCallback<DateTime?> dateRangeCallBack;

        public Home() {
            chartValue = new Chart("Month");
            InitializeDate();
        }

        public void OndateDateRangeChanged(DateTime? dateRange1, DateTime dateRange2)
        {
            dateRange1 = _dateRange.Start.Value ;
            dateRange2 = _dateRange.End.Value;

        }

        void InitializeDate()
        {


			switch (chartValue.Name)
            {
                case "Month":
                    ChartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.AddMonths(1).ToString("dddd, dd MMMM yyyy");
                    break;
                case "Quarterly":
                    ChartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.AddMonths(4).ToString("dddd, dd MMMM yyyy");
                    break;
                case "Annually":
                    ChartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.AddMonths(12).ToString("dddd, dd MMMM yyyy");
                    break;
                case "Custom":
					DateTime dateRange1 = _dateRange.Start.Value;
					DateTime dateRange2 = _dateRange.End.Value;

					OndateDateRangeChanged(dateRange1, dateRange2);

					if (dateRange1 != null && dateRange2 != null)
                    {
						ChartDate = dateRange1.ToString() + dateRange2.ToString();
					}
                    
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