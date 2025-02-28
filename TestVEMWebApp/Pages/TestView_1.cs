using Bunit;
using Microsoft.Extensions.DependencyInjection;
using VEMWebApp.Pages;

namespace TestVEMWebApp
{
  [Collection("VEMWebApp")]
  public class TestView_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbRippleModule));
      var componentUnderTest = ctx.RenderComponent<View_1>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
