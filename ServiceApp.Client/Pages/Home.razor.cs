using MudBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ServiceApp.Client.Pages
{
    public partial class Home
    {
        private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.
        int dataSize = 4;
        double[] data = { 77, 25, 20, 5 };
        string[] labels = { "Uranium", "Plutonium", "Thorium", "Caesium", "Technetium", "Promethium",
                        "Polonium", "Astatine", "Radon", "Francium", "Radium", "Actinium", "Protactinium",
                        "Neptunium", "Americium", "Curium", "Berkelium", "Californium", "Einsteinium", "Mudblaznium" };

        Random random = new Random();

        void RandomizeData()
        {
            var new_data = new double[dataSize];
            for (int i = 0; i < new_data.Length; i++)
                new_data[i] = random.NextDouble() * 100;
            data = new_data;
            StateHasChanged();
        }

        void AddDataSize()
        {
            if (dataSize < 20)
            {
                dataSize = dataSize + 1;
                RandomizeData();
            }
        }
        void RemoveDataSize()
        {
            if (dataSize > 0)
            {
                dataSize = dataSize - 1;
                RandomizeData();
            }
        }
    }
}