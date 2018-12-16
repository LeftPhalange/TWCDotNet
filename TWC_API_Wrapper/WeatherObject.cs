using Newtonsoft.Json;
using System;
using System.Net;

namespace TWC_API_Wrapper
{
    public class WeatherObject
    {
        private readonly string _apiKey, _long, _lat;
        private WebClient _wc;
        public readonly static string _url = "https://api.weather.com/v2/turbo/{0}?apiKey={1}&format=json&geocode={2},{3}&language=en-US&units=e";
        public enum QueryType
        {
            Observation,
            Hourly,
            Daily
        }
        public WeatherObject (string APIKey, string Longitude, string Latitude)
        {
            _apiKey = APIKey;
            _long = Longitude;
            _lat = Latitude;
            _wc = new WebClient();
        }

        public WeatherObservation GetWeatherObservation()
            => JsonConvert.DeserializeObject<WeatherObservation>(_wc.DownloadString(string.Format(_url, ReturnType(QueryType.Observation), _apiKey, _lat, _long)));
        public HourlyForecast GetHourlyForecast()
            => JsonConvert.DeserializeObject<HourlyForecast>(_wc.DownloadString(string.Format(_url, ReturnType(QueryType.Hourly), _apiKey, _lat, _long)));
        public DailyForecast GetDailyForecast()
            => JsonConvert.DeserializeObject<DailyForecast>(_wc.DownloadString(string.Format(_url, ReturnType(QueryType.Daily), _apiKey, _lat, _long)));

        public string ReturnType (QueryType Type)
        {
            string TypeStr = null;
            switch (Type)
            {
                case QueryType.Observation:
                    TypeStr = "vt1observation";
                    break;
                case QueryType.Hourly:
                    TypeStr = "vt1hourlyforecast";
                    break;
                case QueryType.Daily:
                    TypeStr = "vt1dailyforecast";
                    break;
            }
            return TypeStr;
        }
    }
}
