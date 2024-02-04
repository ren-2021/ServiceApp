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

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class PrintTransaction : BasePrintTransaction, IPrintTransaction
    {
        private PrintingInfo printingInfo;
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
            this.Validation();
            this.Generate();
            return this.printingInfo;
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

        private void Validation()
        {
            this.isValid = false;
            if (this.transactionInfo != null && this.mainServices != null)
            {
               this.isValid = true;
            }
        }

        private string Generate()
        {

            try
            {
                Settings.License = LicenseType.Community;
                var document = new TransactionDocument(this.transactionInfo, this.mainServices);
                document.GeneratePdfAndShow();
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
