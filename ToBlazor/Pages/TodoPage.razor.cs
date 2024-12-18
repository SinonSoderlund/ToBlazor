using Microsoft.AspNetCore.Components;
using ToBlazor.Contracts.Services;
using ToBlazor.Entities;

namespace ToBlazor.Pages
{
    #nullable disable
    public partial class TodoPage
    {
        [Inject]
        private IDataService<Todo> dataService { get; init; }
        private List<Todo> todoList = new();

        private Todo inData = new();

        protected override async Task OnInitializedAsync()
        {
            var res = await dataService.GetAllAsync();
            if (res != null && res.Data is List<Todo> data)
            {
                todoList = data;
            }
            await base.OnInitializedAsync();
        }

        private async Task AddNewTodo()
        {
            if (inData != null)
            {
                var outp = await dataService.CreateAsync(new Request<Todo>(inData));
                //todoList.Add(outp.Data);
                inData = new();
            }
        }

    }
}
