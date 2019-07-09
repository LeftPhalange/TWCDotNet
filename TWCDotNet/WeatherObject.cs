using Newtonsoft.Json;
using System;
using System.Net;
using TWCDotNet.Models__V1_;
using TWCDotNet.Models__V2_;
using TWCDotNet.Models__V3_;

namespace TWCDotNet
{
    public class WeatherObject
    {
        private readonly string _apiKey, _geocode, _location;
        private LocationType _locType;
        private WebClient _wc;
        public static string _urlV1 = "https://api.weather.com/v1/{0}/{1}/{2}?apiKey={3}&language=en-US&units=e";
        public static string _urlV2 = "https://api.weather.com/v2/turbo/{0}?apiKey={1}&format=json&geocode={2}&language=en-US&units=e";
        public static string _urlV3 = "https://api.weather.com/v3/{0}?language=EN&apiKey={1}&geocode={2}&format=json";
        public enum QueryType
        {
            Observation,
            Hourly,
            Daily,
            Headlines,
            AirQuality
        }

        public enum LocationType
        {
            Location,
            Geocode
        }

        public enum APIType
        {
            V1,
            V2,
            V3
        }
        public WeatherObject(string APIKey, string Location) // can be either location or geocode, location is V1 only
        {
            _location = Location.Trim();
            LocationType LocType = Location.Contains(",") ? LocationType.Geocode : LocationType.Location; // delimiter is needed to know if this is a location ID or geocode
            if (LocType == LocationType.Geocode)
                _geocode = Location;
            else
                _geocode = null;
            _locType = LocType;
            _apiKey = APIKey;
            _wc = new WebClient();
        }
        private string[] _getQueryArgs(QueryType ProductType)
        {
            if (_locType == LocationType.Location)
                return new string[] { "location", _location, _returnType(ProductType, APIType.V1), _apiKey };
            else
                return new string[] { "geocode", _geocode, _returnType(ProductType, APIType.V1), _apiKey };
        }

        public WeatherObservationV2 GetWeatherObservationVT1()
            => JsonConvert.DeserializeObject<WeatherObservationV2>(_wc.DownloadString(string.Format(_urlV2, _returnType(QueryType.Observation, APIType.V2), _apiKey, _geocode)));
        public HourlyForecastV2 GetHourlyForecastVT1()
            => JsonConvert.DeserializeObject<HourlyForecastV2>(_wc.DownloadString(string.Format(_urlV2, _returnType(QueryType.Hourly, APIType.V2), _apiKey, _geocode)));
        public DailyForecastV2 GetDailyForecastVT1()
            => JsonConvert.DeserializeObject<DailyForecastV2>(_wc.DownloadString(string.Format(_urlV2, _returnType(QueryType.Daily, APIType.V2), _apiKey, _geocode)));
        public HeadlinesV3 GetHeadlinesV3()
            => JsonConvert.DeserializeObject<HeadlinesV3>(_wc.DownloadString(string.Format(_urlV3, _returnType(QueryType.Headlines, APIType.V3), _apiKey, _geocode)));
        public WeatherObservationV1 GetWeatherObservation()
            => JsonConvert.DeserializeObject<WeatherObservationV1>(_wc.DownloadString(string.Format(_urlV1, _getQueryArgs(QueryType.Observation))));
        public DailyForecast10Day GetDailyForecast10Day()
            => JsonConvert.DeserializeObject<DailyForecast10Day>(_wc.DownloadString(string.Format(_urlV1, _getQueryArgs(QueryType.Daily))));
        public AirQuality GetAirQuality()
            => JsonConvert.DeserializeObject<AirQuality>(_wc.DownloadString(string.Format(_urlV1.Replace("&units=e", string.Empty), _getQueryArgs(QueryType.AirQuality))));
        private string _returnType (QueryType Type, APIType API)
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
                    TypeStr = (API == APIType.V2) ? "vt1dailyforecast" : "forecast/daily/10day.json";
                    break;
                case QueryType.Headlines:
                    TypeStr = (API == APIType.V3) ? "alerts/headlines" : "alerts/headlines";
                    break;
                case QueryType.AirQuality: // V1 only
                    TypeStr = "airquality.json";
                    break;
            }
            return TypeStr;
        }
    }
}
