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
        typeof(IgbHierarchicalGridModule),
        typeof(IgbDatePickerModule),
        typeof(IgbSelectModule),
        typeof(IgbTextareaModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbCheckboxModule),
        typeof(IgbInputModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbStepperModule));
      ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
      var componentUnderTest = ctx.RenderComponent<Genset>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
