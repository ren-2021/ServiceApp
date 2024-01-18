using iTextSharp.text.pdf;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class PrintTransaction : BasePrintTransaction, IPrintTransaction
    {
        private PrintingInfo printingInfo;
        private TransactionInfo transactionInfo;
        private bool isValid;
        public PrintTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {

        }
        public PrintingInfo Print()
        {
            this.Initialize();
            this.Validation();
            this.Generate();
            return this.printingInfo;
        }

        private void Initialize()
        {
            this.transactionInfo = this.DLPrint.GetTransactionInfo();
        }


        private void Validation()
        {
            this.isValid = false;
            if (this.transactionInfo != null)
            {
               this.isValid = true;
            }
        }

        private string Generate()
        {
            try
            {
                string pdfTemplate = "";
                pdfTemplate = this.Template;
                string filename = "SampleFile_" + Guid.NewGuid().ToString() + ".pdf";
                string strFolderName = "";
                string newFile = strFolderName + filename;
                PdfReader pdfReaders = new PdfReader(File.ReadAllBytes(pdfTemplate));
                PdfStamper pdfStampers = new PdfStamper(pdfReaders, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStampers.AcroFields;
                //pdfFormFields.SetField();
                pdfStampers.FormFlattening = true;
                pdfStampers.Close();

                return filename;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
