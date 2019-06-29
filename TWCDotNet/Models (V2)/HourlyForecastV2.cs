using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TWCDotNet.Models__V2_
{
    public class HourlyForecastV2
    {
        [JsonProperty("vt1hourlyforecast")]
        public VT1Forecast HourlyForecastData { get; set; }
    }
    public class VT1Forecast
    {
        [JsonProperty("processTime")]
        public List<string> ProcessTime { get; set; }
        [JsonProperty("temperature")]
        public List<int> Temperature { get; set; }
        [JsonProperty("precipPct")]
        public List<int> PrecipPct { get; set; }
        [JsonProperty("precipType")]
        public List<string> PrecipType { get; set; }
        [JsonProperty("uvIndex")]
        public List<int> UVIndex { get; set; }
        [JsonProperty("icon")]
        public List<int> Icon { get; set; }
        [JsonProperty("iconExtended")]
        public List<int> IconExtended { get; set; }
        [JsonProperty("windDirCompass")]
        public List<string> WindDirCompass { get; set; }
        [JsonProperty("windDirDegrees")]
        public List<int> WindDirDegrees { get; set; }
        [JsonProperty("windSpeed")]
        public List<int> WindSpeed { get; set; }
        [JsonProperty("phrase")]
        public List<string> Phrase { get; set; }
        [JsonProperty("dayInd")]
        public List<string> DayInd { get; set; } // is it day yet?
        [JsonProperty("severity")]
        public List<int> Severity { get; set; }
        [JsonProperty("rh")]
        public List<int> RelativeHumidity { get; set; }
        [JsonProperty("feelsLike")]
        public List<double> FeelsLike { get; set; }
    }
}
