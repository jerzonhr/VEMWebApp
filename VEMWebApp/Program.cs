using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VEMWebApp;
using VEMWebApp.Northwind;
using VEMWebApp.Financial;
using VEMWebApp.NorthwindSwagger;
using VEMWebApp.State;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<INorthwindService, NorthwindService>();
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INorthwindSwaggerService, NorthwindSwaggerService>();
builder.Services.AddScoped<IStateService, StateService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbTabsModule),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbActionStripModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbInputModule),
        typeof(IgbSelectModule),
        typeof(IgbDatePickerModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbCheckboxModule),
        typeof(IgbTextareaModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbStepperModule),
        typeof(IgbComboModule)
    );
}