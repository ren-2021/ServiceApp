using Microsoft.Extensions.Configuration;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Print
{
    public class TransactionDocument : IDocument
    {

        public TransactionInfo TransactionInfo { get; }
        public IEnumerable<PrintModel> MainServices { get; }

        public TransactionDocument(TransactionInfo _transactionInfo, IEnumerable<PrintModel> _mainServices)
        {
            TransactionInfo = _transactionInfo;
            MainServices = _mainServices;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });
                });
        }

        void ComposeHeader(IContainer container)
        {
            IConfiguration Configuration = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json").Build();

            var imagePathSettings = Configuration["Document:Logo"].ToString();
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column
                        .Item().Text($"Transaction # 1")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Issue date: ").SemiBold();
                        text.Span($"09-09-2023");
                    });

                });
                

                if (imagePathSettings != null)
                {
                    string logoImagePath = imagePathSettings;
                    byte[] imageData = File.ReadAllBytes(logoImagePath);
                    row.ConstantItem(175).Image(imageData);
                }
            });
        }

        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(20);
                column.Item().Element((container) => AccountingTable(container, "Accounting"));
                column.Item().Element((container) => AccountingTable(container, "OtherServices"));
                column.Item().Element((container) => AccountingTable(container, "PSA"));
                column.Item().Element((container) => AccountingTable(container, "DFA"));
                column.Item().Element((container) => AccountingTable(container, "Airline"));
                column.Item().Element((container) => AccountingTable(container, "VISAProcessing"));
                column.Item().Element((container) => AccountingTable(container, "Financial"));
            });
        }
        void AccountingTable(IContainer container, string ServiceType)
        {
            var headerStyle = TextStyle.Default.SemiBold();

            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header =>
                {
                    header.Cell().Text("#");
                    header.Cell().Text($"{ServiceType}").Style(headerStyle);
                    header.Cell().AlignRight().Text("Sole Proprietorship").Style(headerStyle).FontSize(11);
                    header.Cell().AlignRight().Text("Corporate").Style(headerStyle).FontSize(11);

                    header.Cell().ColumnSpan(4).PaddingTop(5).BorderBottom(1).BorderColor(Colors.Black);
                });

                var services = MainServices.Where(x => x.ServiceType == ServiceType).ToList();

                foreach (var item in services)
                {
                    table.Cell().Element(CellStyle).Text($" ");
                    table.Cell().Element(CellStyle).Text(item.Description).FontSize(8);
                    table.Cell().Element(CellStyle).AlignRight().Text((item.OwnershipType == 1)? $"{item.Fee:C}" : "").FontSize(8);
                    table.Cell().Element(CellStyle).AlignRight().Text((item.OwnershipType == 2) ? $"{item.Fee:C}" : "").FontSize(8);

                    static IContainer CellStyle(IContainer container) => container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                }
            });
        }
    }

    public class AddressComponent : IComponent
    {
        private string Title { get; }
        private Address Address { get; }

        public AddressComponent(string title, Address address)
        {
            Title = title;
            Address = address;
        }

        public void Compose(IContainer container)
        {
            container.ShowEntire().Column(column =>
            {
                column.Spacing(2);

                column.Item().Text(Title).SemiBold();
                column.Item().PaddingBottom(5).LineHorizontal(1);

                column.Item().Text(Address.CompanyName);
                column.Item().Text(Address.Street);
                column.Item().Text($"{Address.City}, {Address.State}");
                column.Item().Text(Address.Email);
                column.Item().Text(Address.Phone);
            });
        }
    }

}
