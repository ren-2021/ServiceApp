using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.Notary
{
    public class Notary : IPricing
    {
        public decimal Fee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
