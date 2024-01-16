using ServiceApp.Shared.Model.Services.Accounting.SubServices;
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
        private readonly ITransferofTitle transferofTitle;
        private readonly IPCABAssistance pcabAssistance;
        private readonly INBIAssistance nbiAssistance;
        private readonly IWeddingManagement weddingManagement;

        public ITransferofTitle TransferofTitle => transferofTitle;
        public IPCABAssistance PCABAssistance => pcabAssistance;
        public INBIAssistance NBIAssistance => nbiAssistance;
        public IWeddingManagement WeddingManagement => weddingManagement;
        public bool IsIncluded { get; set; }

        public OtherServices(ITransferofTitle _transferofTitle, IPCABAssistance _pcabAssistance, INBIAssistance _nbiAssistance, IWeddingManagement _weddingManagement)
        {
            this.transferofTitle = _transferofTitle;
            this.pcabAssistance = _pcabAssistance;
            this.nbiAssistance = _nbiAssistance;
            this.weddingManagement = _weddingManagement;
        }

    }
}
