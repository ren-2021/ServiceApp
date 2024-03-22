using MudBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model.Chart;
using ServiceApp.Client.Enum;

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

        protected override async Task OnInitializedAsync()
        {
            chartValue = new Chart(Timeline.Month.ToString());
            InitializeDate();
            ChartData = await ChartService.GetChartPercentage((int)Timeline.Month);
            labels = ChartData.Select(x => $"{x.Service}: {x.Percentage}%").ToArray();
            data = ChartData.Select(x => x.Percentage).ToArray();
        }

        private async Task InitializeDate()
        {
            if(chartValue.Name == Timeline.Month.ToString())
            {
                ChartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.AddMonths(1).ToString("dddd, dd MMMM yyyy");
                ChartData = await ChartService.GetChartPercentage((int)Timeline.Month);
            }
            else if(chartValue.Name == Timeline.Quarterly.ToString())
            {
                ChartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.AddMonths(4).ToString("dddd, dd MMMM yyyy");
                ChartData = await ChartService.GetChartPercentage((int)Timeline.Quarterly);
            }
            else
            {
                ChartDate = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " - " + DateTime.Now.AddMonths(12).ToString("dddd, dd MMMM yyyy");
                ChartData = await ChartService.GetChartPercentage((int)Timeline.Annually);
            }
        }
    }
}