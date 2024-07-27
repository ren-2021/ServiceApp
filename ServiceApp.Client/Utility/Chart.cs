using ServiceApp.Client.Enum;

namespace ServiceApp.Client.Utility
{
     public class Chart
    {
        public string Name { get; set; }
        public Timeline? Timeline { get; set; }
        public DateTime? Date1 { get; set; }
        public Chart(string name)
        {
            Name = name;
        }

        public override bool Equals(object o)
        {
            var other = o as Chart;
            return other?.Name == Name;
        }

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
        public override string ToString() => Name;
    }
}
