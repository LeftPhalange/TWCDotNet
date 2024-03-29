﻿# TWCDotNet (api.weather.com C# wrapper)

TWCDotNet is a wrapper for the weather.com API (The Weather Channel) written in C#/.NET Standard 2.0. This API is for use with those who have subscribed to the service, such as businesses and other clients in the enterprise.

## Prerequisite:
| Library | Link |
|---------|------|
| Newtonsoft.JSON (also available as a NuGet package, install it before use) | https://www.newtonsoft.com/json |
This prerequisite is important if you are implementing this class library as a dependency or reference.

## TWCDotNet supports v1, v2, and v3 products
* The following V1 products are supported:
    - Alerts
    - Daily Forecast (10-Day)
    - Weather Observations
    - Air Quality Forecast
* The following V2 (VT1) products are supported:
    - Daily Forecast
    - Hourly Forecast
    - Weather Observations
* The following V3 product is supported:
    - Headlines

## How do I get started?
In Visual Studio, create a new project (or open your existing one), and then right-click Dependencies or References where the Solution Explorer is, and click Add.

Wherever you put the DLL for TWCDotNet in your working directory, browse for it, and then add it as your reference or dependency. A copy of it should be in your solution.

You should then be able to create a new instance of the object WeatherObject. WeatherObject takes two arguments for instantiation:
* `string APIKey`
* `string Location` (example format: "33.75,-84.39" for geocode or "USNY0483:1:US" for location, used to fetch high-resolution weather data)

*NOTE*: Geocodes can be used in all v1, v2, and v3 products. Location is known to only work when using v1 products. So if you instantiate the WeatherObject class, be sure if you are using a non-geocode location you should work with v1 products only, or use the same key you would for all products to use an instance of the object each time.

You have the following public methods to work from:
- `GetWeatherObservationVT1()`: Fetches weather observations from the V2/VT1 product based on the location you have provided
- `GetHourlyForecastVT1()`: Fetches hourly forecast data from the V2/VT1 product based on the location you have provided
- `GetDailyForecastVT1()`: Fetches daily forecast data from the V2/VT1 product for the location you have provided (for 10-day, use the V1 modeled product by using GetDailyForecast10Day)
- `GetHeadlinesV3()`: Fetches headline data (V3 modeled product), or bulletins issued by the National Weather Service, for the area specified in the location
- `GetWeatherObservation()`: Fetches observation data through the V1 product, provides less visible products like ceiling data (in feet)
- `GetDailyForecast10Day()`: A more comprehensive V1 model product fetching daily forecast data for the next 10 days
- `GetAirQuality()`: V1 product that lets you fetch air quality data based on the location you have provided

To use these products once and for all, create a new object of its returning type (from whatever method above that you use), and perform the following to fetch the fields:
```
WeatherObject _weatherObject = new WeatherObject(_apiKey, _geocode);
var forecastData = _weatherObject.GetDailyForecast10Day().ForecastList;
```
The above example uses the `GetDailyForecast10Day()` method (of returning type `Forecasts`), it uses an array of that type since there are multiple instances of the JSON key "forecasts" in the feed.

## What are some fields I can use for each product?
Please refer to the classes in each model, you can see those by opening TWCDotNet as a solution.

### Summary
The TWCDotNet API was made for enterprise developers to provide weather data breezily, without creating classes to parse hundreds of fields.
Credits to The Weather Channel / IBM for the JSON API. I do not work for them, I only made the wrapper for ease of use to prospective developers who want to use the API.

I reiterate that this API is for official use only.

This project is made under the MIT license for open source software.
