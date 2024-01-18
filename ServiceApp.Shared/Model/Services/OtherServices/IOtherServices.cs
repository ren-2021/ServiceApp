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
        public TransferofTitle TransferofTitle { get; set; }
        public PCABAssistance PCABAssistance { get; set; }
        public NBIAssistance NBIAssistance { get; set; }
        public WeddingManagement WeddingManagement { get; set; }
        public bool IsIncluded { get; set; }
    }
}
