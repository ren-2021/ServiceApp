using ServiceApp.BusinessLayer.Model;
using Microsoft.Extensions.Configuration;
using ServiceApp.DataAccessLayer;

namespace ServiceApp.ServiceLayer
{
    public class BaseDataAccessFactory
    {
        private List<IDataAccess> _dataAcesses;
        public List<IDataAccess> dataAcesses { get { return this._dataAcesses; } }

        public IConfiguration Configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json").Build();

        public BaseDataAccessFactory()
        {
            this.RegisterDataAcesses();
        }

        private void RegisterDataAcesses()
        {
            this._dataAcesses = new List<IDataAccess>();
            this._dataAcesses.Add(new DLBaseService());
        }
    }
}
