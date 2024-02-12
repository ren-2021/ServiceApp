using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public class TransactionInfoContainer
    {
        public TransactionInfo Value {  get; set; }
        public event Action OnStateChange;

        public void SetValue(TransactionInfo value)
        {
            this.Value = value;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
