Feature: WeatherForecast

@mytag
Scenario: Get Weather
	When I request today's weather
	Then the response should have a 200 status code

Scenario: Get Today's Temperature in Celsius
	When I request today's weather
	Then the response content should have 