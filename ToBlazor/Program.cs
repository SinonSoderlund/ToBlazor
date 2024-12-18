using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToBlazor.Contracts.Data;
using ToBlazor.Contracts.Repositories;
using ToBlazor.Contracts.Services;
using ToBlazor.Data;
using ToBlazor.Entities;
using ToBlazor.Repositories;
using ToBlazor.Services;

namespace ToBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<IDataStore<IdList<Todo>>, VolatileTodoDataStore>();
            builder.Services.AddScoped<IDataRepository<Todo>, VolatileTodoDataRepository>();
            builder.Services.AddScoped<IDataService<Todo>, VolatileTodoDataService>();

            await builder.Build().RunAsync();
        }
    }
}
