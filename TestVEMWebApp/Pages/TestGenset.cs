using Bunit;
using Microsoft.Extensions.DependencyInjection;
using VEMWebApp.Pages;
using VEMWebApp.Northwind;

namespace TestVEMWebApp
{
  [Collection("VEMWebApp")]
  public class TestGenset
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbTabsModule),
        typeof(IgbGridModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbSelectModule),
        typeof(IgbInputModule),
        typeof(IgbDatePickerModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbCheckboxModule),
        typeof(IgbTextareaModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule));
      ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
      var componentUnderTest = ctx.RenderComponent<Genset>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
