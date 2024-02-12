using iTextSharp.text.pdf;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using QuestPDF.Previewer;
using Document = QuestPDF.Fluent.Document;
using QuestPDF.Helpers;
using ServiceApp.BusinessLayer.DomainServices.Print;
using ServiceApp.Shared.Model.ModelRequest;
using QuestPDF;
using Microsoft.Extensions.Configuration;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class PrintTransaction : BasePrintTransaction, IPrintTransaction
    {
        IConfiguration Configuration = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json").Build();

        private IPrintingInfo PrintingInfo;
        private TransactionInfo transactionInfo;
        private IEnumerable<PrintModel> mainServices;
        private int TransactionID { get; set; }
        public PrintTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {

        }
        public PrintingInfo Print(int _transactionID)
        {
            this.TransactionID = _transactionID;
            this.InitializeTransaction();
            this.InitializeServices();
            this.SavePrintInfo();
            this.Validation();
            this.Generate();
            return (PrintingInfo)this.PrintingInfo;
        }

        public IEnumerable<PrintModel> GetServicesInfo(int _transactionID) 
        {
            this.TransactionID = _transactionID;
            this.InitializeServices();
            return this.mainServices;
        }

        private void InitializeTransaction()
        {
            this.transactionInfo = this.DLPrint.GetTransactionInfoByID(this.TransactionID);
        }

        private void InitializeServices()
        {
            this.mainServices = this.DLPrint.GetTransactionServicesInfo(this.TransactionID);
        }

        private void SavePrintInfo()
        {
            this.PrintingInfo = new PrintingInfo();
            var path = Configuration["Printing:PDFFolder"].ToString();
            this.PrintingInfo.FileName = $"Sherpherd_TransactionNo{this.TransactionID}_{Guid.NewGuid().ToString()}.pdf";
            this.PrintingInfo.FullPath = $"{path}{PrintingInfo.FileName}";
            this.DLPrint.SavePrintingInfo(this.TransactionID, this.PrintingInfo.FileName, this.PrintingInfo.FullPath);
        }

        private void Validation()
        {
            this.isValid = false;
            if (this.transactionInfo != null && this.mainServices != null)
            {
               this.isValid = true;
            }
        }

        private void Generate()
        {
            Settings.License = LicenseType.Community;
            var document = new TransactionDocument(this.transactionInfo, this.mainServices);
            GenerateExtensions.GeneratePdf(document, this.PrintingInfo.FullPath);
        }
    }
}
