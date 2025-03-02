using CurrieTechnologies.Razor.SweetAlert2;
using MatchPro.Frontend.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MatchPro.Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7236") });
            builder.Services.AddScoped<IEquipoService, EquipoService>();
            builder.Services.AddScoped<IImagenService, ImagenService>();
            builder.Services.AddSweetAlert2();
            await builder.Build().RunAsync();
        }
    }
}
