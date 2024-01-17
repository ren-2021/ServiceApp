using ServiceApp.Shared.Model.Services.OtherServices.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.OtherServices
{
    public interface IOtherServices
    {
        public ITransferofTitle TransferofTitle { get; set; }
        public IPCABAssistance PCABAssistance { get; set; }
        public INBIAssistance NBIAssistance { get; set; }
        public IWeddingManagement WeddingManagement { get; set; }
        public bool IsIncluded { get; set; }
    }
}
