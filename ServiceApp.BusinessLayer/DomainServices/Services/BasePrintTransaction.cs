using Microsoft.Extensions.Configuration;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class BasePrintTransaction : BaseDataAccess
    {
        private string sourceFolder;
        public IConfiguration Configuration = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json").Build();
        public string SourceFolder { get{ return sourceFolder; } }
        public IDLPrint DLPrint { get { return this.dlBaseService.DLPrint; } }

        public BasePrintTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {
            sourceFolder = Configuration["Printing:PDFFolder"].ToString();
        }
        public BasePrintTransaction()
        {

        }
    }
}
