using ServiceApp.Client.Utility;
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
        public async Task<IEnumerable<Chart>> GetChartPercentage(Chart chart)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Chart>>($"api/Dashboard/GetChartPercentage/");
            return result;
        }
    }
}
