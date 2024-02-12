using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public interface IPrintingInfo
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? FullPath { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
