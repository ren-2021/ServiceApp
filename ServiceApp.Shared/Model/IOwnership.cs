using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public interface IOwnership
    {
        public OwnerType OwnerType {  get; set; }
    }
}
