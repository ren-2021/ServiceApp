using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System.Net.Http.Json;

namespace ServiceApp.Client.Services
{
    public class PrintService: IPrintService
    {
        private readonly HttpClient _httpClient;

        public PrintService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PrintModel>> GetServicesInfo(int _transactionID)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<IEnumerable<PrintModel>>($"api/Print/GetServiceInfo/{_transactionID}");
                return result ?? Enumerable.Empty<PrintModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching transactions: {ex.Message}");
                return Enumerable.Empty<PrintModel>();
            }
        }
    }
}
