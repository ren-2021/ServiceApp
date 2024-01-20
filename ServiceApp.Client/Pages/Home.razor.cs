using MudBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ServiceApp.Client.Pages
{
    public partial class Home
    {
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
        void RandomizeData()
        {
            var new_data = new double[dataSize];
            for (int i = 0; i < new_data.Length; i++)
                new_data[i] = random.NextDouble() * 100;
            data = new_data;
            StateHasChanged();
        }

        void AddDataSize()
        {
            if (dataSize < 20)
            {
                dataSize = dataSize + 1;
                RandomizeData();
            }
        }
        void RemoveDataSize()
        {
            if (dataSize > 0)
            {
                dataSize = dataSize - 1;
                RandomizeData();
            }
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