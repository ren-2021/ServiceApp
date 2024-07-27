using MudBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model.Chart;
using ServiceApp.Client.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ServiceApp.Client.Services;

namespace ServiceApp.Client.Pages
{
    public partial class Home
    {
        private int Index = -1;
        private Chart chartValue;
        private string ChartDate;
        IEnumerable<ChartModel> ChartData;
        int dataSize = 4;
        double[] data;
        string[] labels;
        DateTime? date1 = new DateTime(2024,06,20);
        int? timeline;


        //public EventCallback<DateTime?> OnDateChanged { get; set; }

        protected override async Task OnInitializedAsync()
        {
            DateTime? date1 = DateTime.Today;
            this.timeline = 1;
            chartValue = new Chart(Timeline.Month.ToString());
            await InitializeDate();
            await CalculatePercenatage(chartValue);
        }

        private async Task InitializeDate()
        {
            int timeline = 0;
            if (chartValue.Name == Timeline.Month.ToString())
            {
                ChartDate = DateTime.Now.AddMonths(-1).ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
                timeline = 1;
            }
            if (chartValue.Name == Timeline.Quarterly.ToString())
            {
                ChartDate = DateTime.Now.AddMonths(-4).ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
                timeline = 2;
            }
            if (chartValue.Name == Timeline.Annually.ToString())
            {
                ChartDate = DateTime.Now.AddMonths(-12).ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
                timeline = 3;
            }
            if (chartValue.Name == Timeline.Daily.ToString())
            {
                //ChartDate = date.Value.ToString("dddd, dd MMMM yyyy");
                timeline = 4;
            }


            OnDateChanged(date1);
            chartValue.Timeline = (Timeline?)timeline;
            chartValue.Date1 = date1;
            await CalculatePercenatage(chartValue);
        }

        void OnDateChanged(DateTime? newDate)
        {
            date1 = newDate;
        }
     
        private async Task CalculatePercenatage(Chart chart )
        {
            ChartData = (IEnumerable<ChartModel>)await ChartService.GetChartPercentage(chart);
            labels = ChartData.Select(x => $"{x.Service}: {x.Percentage}%").ToArray();
            data = ChartData.Select(x => x.Percentage).ToArray();
        }
    }
}