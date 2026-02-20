using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OutfitRandomizer.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// W pliku Program.cs projektu .Client
builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri("szafa-api-pjay-ejevf0h5gvd5fvfp.germanywestcentral-01.azurewebsites.net") // Wpisz TU swój adres z API
});

await builder.Build().RunAsync();