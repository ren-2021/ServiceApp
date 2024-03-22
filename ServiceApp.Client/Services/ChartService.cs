using ServiceApp.Shared.Model.Chart;
using ServiceApp.Shared.Model.ModelRequest;
using System.Net.Http;
using System.Net.Http.Json;

namespace ServiceApp.Client.Services
{
    public class ChartService : IChartService
    {
        private readonly HttpClient _httpClient;

        public ChartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ChartModel>> GetChartPercentage(int timeline)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<ChartModel>>($"api/Dashboard/GetChartPercentage/{timeline}");
            return result;
        }
    }
}
