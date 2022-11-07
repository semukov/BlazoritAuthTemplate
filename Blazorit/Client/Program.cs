using Blazored.LocalStorage;
using Blazorit.Client;
using Blazorit.Client.Services.AuthService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage(); //custom add
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAuthService, AuthService>(); //custom add
builder.Services.AddOptions(); //custom add
builder.Services.AddAuthorizationCore(); //custom add
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>(); //custom add

await builder.Build().RunAsync();
