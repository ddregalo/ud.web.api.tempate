using System;
using TechTalk.SpecFlow;

namespace UDWebAPITemplateApp.AcceptanceTest.StepDefinitions;

[Binding]
public class WeatherForecastStepDefinitions
{
    private readonly HttpClient httpClient;
    private HttpResponseMessage getWeatherForecastResponse;

    public WeatherForecastStepDefinitions(HttpClient httpClient) => 
        this.httpClient = httpClient;

    [When(@"I request today's weather")]
    public async Task WhenIRequestTodaysWeather()
    {
        getWeatherForecastResponse = await httpClient.GetAsync("weatherforecast");
    }

    [Then(@"the response should have a (.*) status code")]
    public void ThenTheResponseShouldHaveAStatusCode(int p0)
    {
        ((int)getWeatherForecastResponse.StatusCode).Should().Be(p0);
    }
}
