using Bunit;
using Microsoft.Extensions.DependencyInjection;
using VEMWebApp.Shared;

namespace TestVEMWebApp
{
  [Collection("VEMWebApp")]
  public class TestMainLayout
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule));
      var componentUnderTest = ctx.RenderComponent<MainLayout>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
