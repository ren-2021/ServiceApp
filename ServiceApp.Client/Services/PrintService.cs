using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System.Net.Http.Json;
using System.Text;

namespace ServiceApp.Client.Services
{
    public class PrintService: IPrintService
    {
        private readonly HttpClient _httpClient;
        private string fileContent;

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

        public async Task Generate(int _transactionID)
        {
            try
            {
               var response = await _httpClient.GetAsync($"api/Print/Generate/{_transactionID}");
                if (response.IsSuccessStatusCode)
                {
                    var contentDisposition = response.Content.Headers.ContentDisposition;
                    var fileName = contentDisposition?.FileName ?? "downloadedFile";
                    var fileBytes = await response.Content.ReadAsByteArrayAsync();
                    var filePath = $"D:\\EOI Projects\\ShepherdShelter\\ServiceApp\\ServiceApp.PDFTemplates\\" + fileName;
                    await File.WriteAllBytesAsync(filePath, fileBytes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching transactions: {ex.Message}");
            }
        }
    }
}
