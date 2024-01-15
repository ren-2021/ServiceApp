namespace ServiceApp.Client.Pages.Services
{
    public partial class Summary
    {
        public record Employee(string Name, string Position, int YearsEmployed, int Salary, int Rating);
        public IEnumerable<Employee> employees;

        protected override void OnInitialized()
        {
            employees = new List<Employee>
        {
            new Employee("Sam", "CPA", 23, 87_000, 4),
            new Employee("Alicia", "Product Manager", 11, 143_000, 5),
            new Employee("Ira", "Developer", 4, 92_000, 3),
            new Employee("John", "IT Director", 17, 229_000, 4),
        };
        }
    }
}