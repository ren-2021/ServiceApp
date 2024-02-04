using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ServiceApp.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Print
{
    public class TransactionComponent : IComponent
    {
        private string Title { get; }
        private TransactionInfo TransactionInfo { get; }

        public TransactionComponent(string title, TransactionInfo transaction)
        {
            Title = title;
            TransactionInfo = transaction;
        }

        public void Compose(IContainer container)
        {
            container.ShowEntire().Column(column =>
            {
                column.Spacing(2);

                column.Item().Text(Title).SemiBold();
                column.Item().PaddingBottom(5).LineHorizontal(1);

                column.Item().Text($"Name: {TransactionInfo.FirstName} {TransactionInfo.LastName}");
                column.Item().Text($"Tin No: {TransactionInfo.TinNo}");
                column.Item().Text($"Email Address: {TransactionInfo.EmailAddress}");
                column.Item().Text($"Home Address: {TransactionInfo.Address}");
            });
        }
    }
}
