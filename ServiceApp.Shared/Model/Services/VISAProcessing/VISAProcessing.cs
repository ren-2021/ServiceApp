using ServiceApp.Shared.Model.Services.PSA.SubServices;
using ServiceApp.Shared.Model.Services.VISAProcessing.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.VISAProcessing
{
    public class VISAProcessing : IVISAProcessing
    {
        public readonly USA usa;   
        public readonly CanadaETA canadaETA;    
        public readonly CanadaRegular canadaRegular;
        public readonly NewZealand newZealand;     
        public readonly China china;     
        public readonly Japan japan;      
        public readonly Australia australia;   
        public readonly EuropeanCountries europeanCountries;   
        public readonly SouthKorea southKorea;
        public USA USA { get => usa; set { } }
        public CanadaETA CanadaETA { get => canadaETA; set { } }
        public CanadaRegular CanadaRegular { get => canadaRegular; set { } }
        public NewZealand NewZealand { get => newZealand; set { } }
        public China China { get => china; set { } }
        public Japan Japan { get => japan; set { } }
        public Australia Australia { get => australia; set { } }
        public EuropeanCountries EuropeanCountries { get => europeanCountries; set { } }
        public SouthKorea SouthKorea { get => southKorea; set { } }
        public bool IsIncluded { get; set; }

        public VISAProcessing(USA usa, CanadaETA canadaETA, CanadaRegular canadaRegular, NewZealand newZealand, China china, Japan japan, Australia australia, EuropeanCountries europeanCountries, SouthKorea southKorea)
        {
            this.usa = usa;
            this.canadaETA = canadaETA;
            this.canadaRegular = canadaRegular;
            this.newZealand = newZealand;
            this.china = china;
            this.japan = japan;
            this.australia = australia;
            this.europeanCountries = europeanCountries;
            this.southKorea = southKorea;
        }
    }
}
