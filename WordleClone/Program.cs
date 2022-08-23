using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WordleClone;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient 
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    //BaseAddress = new Uri("https://random-word-api.herokuapp.com/word?length=5")
});

await builder.Build().RunAsync();
