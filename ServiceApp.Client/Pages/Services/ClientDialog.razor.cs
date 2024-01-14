using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Net.Http.Json;
using static MudBlazor.CategoryTypes;

namespace ServiceApp.Client.Pages.Services
{
    public partial class ClientDialog
    {
        public record Employee(string Name, string Position, int YearsEmployed, int Salary, int Rating);
        public IEnumerable<Employee> employees;
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        
        void Submit() => MudDialog.Close(DialogResult.Ok(true));
        void Cancel() => MudDialog.Cancel();

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
        void RowCellClicked(string name)
        {

        }
    }
}