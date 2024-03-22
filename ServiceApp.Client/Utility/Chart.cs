namespace ServiceApp.Client.Utility
{
     public class Chart
    {
        public Chart(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override bool Equals(object o)
        {
            var other = o as Chart;
            return other?.Name == Name;
        }

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
        public override string ToString() => Name;
    }
}
