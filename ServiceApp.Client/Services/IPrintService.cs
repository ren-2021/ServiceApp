using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;

namespace ServiceApp.Client.Services
{
    public interface IPrintService
    {
        public Task<IEnumerable<PrintModel>> GetServicesInfo(int _transactionID);

        public Task Generate(int _transactionID);
    }
}
