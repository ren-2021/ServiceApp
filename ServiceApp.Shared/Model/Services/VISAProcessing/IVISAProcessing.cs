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
        public IUSA USA { get; set; }
        public ICanadaETA CanadaETA { get; set; }
        public ICanadaRegular CanadaRegular { get; set; }
        public INewZealand NewZealand { get; set; }
        public IChina China { get; set; }
        public IJapan Japan { get; set; }
        public IAustralia Australia { get; set; }
        public IEuropeanCountries EuropeanCountries { get; set; }
        public ISouthKorea SouthKorea { get; set; }
        public bool IsIncluded { get; set; }
    }
}
