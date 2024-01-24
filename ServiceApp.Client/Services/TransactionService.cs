using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Shared.Model.Services.ATMPortable;
using ServiceApp.Shared.Model.Services.DFA;
using ServiceApp.Shared.Model.Services.LTO;
using ServiceApp.Shared.Model.Services.Notary;
using ServiceApp.Shared.Model.Services.OtherServices.SubServices;
using ServiceApp.Shared.Model.Services.OtherServices;
using ServiceApp.Shared.Model.Services.VISAProcessing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using ServiceApp.Shared.Model.Services.Airline;
using ServiceApp.Shared.Model.Services.PSA;
using ServiceApp.Shared.Model.Services.Financial;

namespace ServiceApp.Client.Services
{
    public class TransactionService: ITransactionService
    {
        private readonly HttpClient _httpClient;

        public TransactionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Process(IClientInfo _clientInfo, IAccounting _accounting,IOtherServices _otherServices,IPSA _psaAssistance,IDFA _dfaServices,INotary _notary,ILTO _ltoServices,IAirline _airlineServices,IVISAProcessing _visaProcessing, IFinancial _financialServices,IATMPortable _atmPortable)
        {
            MainRequest request = new MainRequest()
            {
                ClientInfo = (ClientInfo)_clientInfo,
                MainServices = new MainServices()
                {
                    Accounting = (Accounting)_accounting,
                    OtherServices = (OtherServices)_otherServices,
                    PSA = (PSA)_psaAssistance,
                    DFA = (DFA)_dfaServices,
                    Notary = (Notary)_notary,
                    LTO = (LTO)_ltoServices,
                    Airline = (Airline)_airlineServices,
                    VISAProcessing = (VISAProcessing)_visaProcessing,
                    Financial = (Financial)_financialServices,
                    ATMPortable = (ATMPortable)_atmPortable
                }
            };
            JsonRequest jsonRequest = new JsonRequest() { JsonString = JsonConvert.SerializeObject(request) };
            var response = await _httpClient.PostAsJsonAsync($"api/Transaction/Process", jsonRequest);
        }

        public async Task<IEnumerable<TransactionInfo>> GetTransactions()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<IEnumerable<TransactionInfo>>($"api/Transaction");
                return result ?? Enumerable.Empty<TransactionInfo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching transactions: {ex.Message}");
                return Enumerable.Empty<TransactionInfo>();
            }
        }
    }
}
