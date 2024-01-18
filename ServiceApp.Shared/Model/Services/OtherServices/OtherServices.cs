using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Shared.Model.Services.LTO.SubService;
using ServiceApp.Shared.Model.Services.OtherServices.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.OtherServices
{
    public class OtherServices : IOtherServices
    {
        private readonly TransferofTitle transferofTitle;
        private readonly PCABAssistance pcabAssistance;
        private readonly NBIAssistance nbiAssistance;
        private readonly WeddingManagement weddingManagement;

        public TransferofTitle TransferofTitle { get => transferofTitle; set { } }
        public PCABAssistance PCABAssistance { get => pcabAssistance; set { } }
        public NBIAssistance NBIAssistance { get => nbiAssistance; set { } }
        public WeddingManagement WeddingManagement { get => weddingManagement; set { } }
        public bool IsIncluded { get; set; }

        public OtherServices(TransferofTitle _transferofTitle, PCABAssistance _pcabAssistance, NBIAssistance _nbiAssistance, WeddingManagement _weddingManagement)
        {
            this.transferofTitle = _transferofTitle;
            this.pcabAssistance = _pcabAssistance;
            this.nbiAssistance = _nbiAssistance;
            this.weddingManagement = _weddingManagement;
        }

    }
}
