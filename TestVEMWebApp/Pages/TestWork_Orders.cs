using Bunit;
using Microsoft.Extensions.DependencyInjection;
using VEMWebApp.Pages;
using VEMWebApp.Financial;
using VEMWebApp.Northwind;

namespace TestVEMWebApp
{
  [Collection("VEMWebApp")]
  public class TestWork_Orders
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbStepperModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbComboModule),
        typeof(IgbGridModule));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
      var componentUnderTest = ctx.RenderComponent<Work_Orders>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
