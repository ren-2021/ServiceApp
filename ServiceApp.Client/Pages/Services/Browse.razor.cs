using MudBlazor;
using System.Net.Http.Json;
using static MudBlazor.CategoryTypes;

namespace ServiceApp.Client.Pages.Services
{
    public partial class Browse
    {
        private bool dense = false;
        private bool hover = true;
        private bool striped = false;
        private bool bordered = false;
        private string searchString1 = "";
        private Element selectedItem1 = null;
        private HashSet<Element> selectedItems = new HashSet<Element>();

        string[] headings = { "ID", "Name", "Email", "Gender", "IP Address" };
        string[] rows = {
        @"1 Krishna kpartner0@usatoday.com Male 28.25.250.202",
        @"2 Webb wstitle1@ning.com Male 237.168.134.114",
        @"3 Nathanil nneal2@cyberchimps.com Male 92.6.0.175",
        @"4 Adara alockwood3@patch.com Female 182.174.217.152",
        @"5 Cecilius cchaplin4@shinystat.com Male 195.124.144.18",
        @"6 Cicely cemerine9@soup.io Female 138.94.191.43",
    };

        private IEnumerable<Element> Elements = new List<Element>();

        protected override async Task OnInitializedAsync()
        {
            Elements = new List<Element>{
                new Element(1, "H", "Hydrogen", 0, 1.00794),
                new Element(2, "He", "Helium", 17, 4.002602),
                new Element(3, "Li", "Lithium", 0, 6.941),
                new Element(4, "Be", "Beryllium", 1, 9.012182),
                new Element(5, "B", "Boron", 12, 10.811),
                new Element(6, "C", "Carbon", 13, 12.0107),
                new Element(7, "N", "Nitrogen", 14, 14.0067),
                new Element(8, "O", "Oxygen", 15, 15.9994),
                new Element(9, "F", "Fluorine", 16, 18.998404),
                new Element(10, "Ne", "Neon", 17, 20.1797)
            };
        }

        private bool FilterFunc1(Element element) => FilterFunc(element, searchString1);

        private bool FilterFunc(Element element, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Sign.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.Name} {element.Position} {element.MolarMass}".Contains(searchString))
                return true;
            return false;
        }
    }

    public class Element
    {
        public int Nr { get; set; }
        public string Sign { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public double MolarMass { get; set; }

        public Element()
        {
        }
        public Element(int nr, string sign, string name, int position, double molarMass)
        {
            Nr = nr;
            Sign = sign;
            Name = name;
            Position = position;
            MolarMass = molarMass;
        }
    }
}