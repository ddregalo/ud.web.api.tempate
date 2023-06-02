using BoDi;
using Microsoft.AspNetCore.Mvc.Testing;

namespace UDWebAPITemplateApp.AcceptanceTest.Hooks;
[Binding]
public class WeatherHooks
{
    private readonly IObjectContainer _objectContainer;

    public WeatherHooks(IObjectContainer objectContainer)
    {
        _objectContainer = objectContainer;
    }

    private WebApplicationFactory<Program> GetWebApplicationFactory() =>
    new WebApplicationFactory<Program>()
        .WithWebHostBuilder(builder => { });

    [BeforeScenario]
    public async Task RegisterServices()
    {
        var factory = GetWebApplicationFactory();
        var client = factory.CreateDefaultClient();
        _objectContainer.RegisterInstanceAs(client);
    }
}
