using ServiceApp.Shared.Model.Services.VISAProcessing.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.VISAProcessing
{
    public interface IVISAProcessing
    {
        public USA USA { get; set; }
        public CanadaETA CanadaETA { get; set; }
        public CanadaRegular CanadaRegular { get; set; }
        public NewZealand NewZealand { get; set; }
        public China China { get; set; }
        public Japan Japan { get; set; }
        public Australia Australia { get; set; }
        public EuropeanCountries EuropeanCountries { get; set; }
        public SouthKorea SouthKorea { get; set; }
        public bool IsIncluded { get; set; }
    }
}
