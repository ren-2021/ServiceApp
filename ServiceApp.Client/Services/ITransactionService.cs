using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared.Model.Services.Airline;
using ServiceApp.Shared.Model.Services.ATMPortable;
using ServiceApp.Shared.Model.Services.DFA;
using ServiceApp.Shared.Model.Services.Financial;
using ServiceApp.Shared.Model.Services.LTO;
using ServiceApp.Shared.Model.Services.Notary;
using ServiceApp.Shared.Model.Services.OtherServices;
using ServiceApp.Shared.Model.Services.PSA;
using ServiceApp.Shared.Model.Services.VISAProcessing;

namespace ServiceApp.Client.Services
{
    public interface ITransactionService
    {
        Task Process(IClientInfo clientInfo, IAccounting Accounting, IOtherServices OtherServices, IPSA PSAAssistance, IDFA DFAServices, INotary Notary, ILTO LTOServices, IAirline AirlineServices, IVISAProcessing VISAProcessing, IFinancial FinancialServices, IATMPortable ATMPortable);

        Task<IEnumerable<TransactionInfo>> GetTransactions();
    }
}
