using Newtonsoft.Json;
using System;
using System.Net;
using TWCDotNet.Models__V1_;
using TWCDotNet.Models__V2_;

namespace TWCDotNet
{
    public class WeatherObject
    {
        private readonly string _apiKey, _geocode;
        private WebClient _wc;
        public readonly static string _urlV1 = "https://api.weather.com/v1/geocode/{0}/{1}/{2}?apiKey={3}&language=en-US&units=e";
        public readonly static string _urlV2 = "https://api.weather.com/v2/turbo/{0}?apiKey={1}&format=json&geocode={2}&language=en-US&units=e";
        
        public enum QueryType
        {
            Observation,
            Hourly,
            Daily
        }
        public enum APIType
        {
            V1,
            V2
        }
        public WeatherObject (string APIKey, string Geocode)
        {
            _apiKey = APIKey;
            _geocode = Geocode;
            _wc = new WebClient();
        }

        public WeatherObservationV2 GetWeatherObservationVT1()
            => JsonConvert.DeserializeObject<WeatherObservationV2>(_wc.DownloadString(string.Format(_urlV2, ReturnType(QueryType.Observation, APIType.V2), _apiKey, _geocode)));
        public HourlyForecastV2 GetHourlyForecastVT1()
            => JsonConvert.DeserializeObject<HourlyForecastV2>(_wc.DownloadString(string.Format(_urlV2, ReturnType(QueryType.Hourly, APIType.V2), _apiKey, _geocode)));
        public DailyForecastV2 GetDailyForecastVT1()
            => JsonConvert.DeserializeObject<DailyForecastV2>(_wc.DownloadString(string.Format(_urlV2, ReturnType(QueryType.Daily, APIType.V2), _apiKey, _geocode)));
        public WeatherObservationV1 GetWeatherObservation()
            => JsonConvert.DeserializeObject<WeatherObservationV1>(_wc.DownloadString(string.Format(_urlV1, _geocode.Split(',')[0], _geocode.Split(',')[1], ReturnType(QueryType.Observation, APIType.V1), _apiKey)));

        public string ReturnType (QueryType Type, APIType API)
        {
            string TypeStr = null;
            switch (Type)
            {
                case QueryType.Observation:
                    TypeStr = (API == APIType.V2) ? "vt1observation" : "observations/current.json";
                    break;
                case QueryType.Hourly:
                    TypeStr = (API == APIType.V2) ? "vt1hourlyforecast" : "hourly/240hour.json";
                    break;
                case QueryType.Daily:
                    TypeStr = (API == APIType.V2) ? "vt1dailyforecast" : "forecast/daily/7day.json";
                    break;
            }
            return TypeStr;
        }
    }
}
