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
        public ITransferofTitle TransferofTitle { get; }
        public IPCABAssistance PCABAssistance { get; }
        public INBIAssistance NBIAssistance { get; }    
        public IWeddingManagement WeddingManagement { get; }
        public bool IsIncluded { get; set; }
    }
}
