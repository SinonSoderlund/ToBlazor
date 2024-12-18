using Microsoft.AspNetCore.Components;
using ToBlazor.Contracts.Services;
using ToBlazor.Entities;

namespace ToBlazor.Components
{
    public partial class TodoEntry
    {
        [Parameter]
        public Todo data { get; init; } = default!;

        [Inject]
        private IDataService<Todo> dataService { get; init; }

        private bool active = true;
        private bool gone = false;

        private void ToggleActive()
        {
            active = !active;
        }

        private async Task DeleteThis()
        {
            await dataService.DeleteAsync(new Request<Todo>(data));
            gone = true;
        }



    }
}
