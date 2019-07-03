using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TWCDotNet.Models__V2_
{
    public class DailyForecastV2
    {
        [JsonProperty("vt1dailyforecast")]
        public VT1DailyForecast[] DailyForecastData { get; set; }
    }
    public class ForecastDay
    {
        [JsonProperty("dayPartName")]
        public string DayPartName { get; set; }
        [JsonProperty("precipPct")]
        public int? PrecipPct { get; set; }
        [JsonProperty("precipAmt")]
        public double? PrecipAmt { get; set; }
        [JsonProperty("precipType")]
        public string PrecipType { get; set; } // if null, no precip is anticipated
        [JsonProperty("temperature")]
        public int? Temperature { get; set; }
        [JsonProperty("uvIndex")]
        public int? UvIndex { get; set; }
        [JsonProperty("uvDescription")]
        public string UvDescription { get; set; }
        [JsonProperty("icon")]
        public int? Icon { get; set; }
        [JsonProperty("iconExtended")]
        public int? IconExtended { get; set; }
        [JsonProperty("phrase")]
        public string Phrase { get; set; }
        [JsonProperty("narrative")]
        public string Narrative { get; set; }
        [JsonProperty("cloudPct")]
        public int? CloudPct { get; set; }
        [JsonProperty("windDirCompass")]
        public string WindDirCompass { get; set; }
        [JsonProperty("windDirDegrees")]
        public int? WindDirDegrees { get; set; }
        [JsonProperty("windSpeed")]
        public int? WindSpeed { get; set; }
        [JsonProperty("humidityPct")]
        public int? HumidityPct { get; set; }
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }
        [JsonProperty("snowRange")]
        public string SnowRange { get; set; }
        [JsonProperty("thunderEnum")]
        public int? ThunderEnum { get; set; }
        [JsonProperty("thunderEnumPhrase")]
        public string ThunderEnumPhrase { get; set; }
    }
    public class VT1DailyForecast
    {
        [JsonProperty("validDate")]
        public string ValidDate { get; set; }
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }
        [JsonProperty("sunset")]
        public string Sunset { get; set; }
        [JsonProperty("moonIcon")]
        public string MoonIcon { get; set; }
        [JsonProperty("moonPhrase")]
        public string MoonPhrase { get; set; }
        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }
        [JsonProperty("moonset")]
        public string Moonset { get; set; }
        [JsonProperty("dayOfWeek")]
        public string DayOfWeek { get; set; }
        [JsonProperty("snowQpf")]
        public double SnowQpf { get; set; }
        [JsonProperty("day")]
        public ForecastDay[] Day { get; set; }
        [JsonProperty("night")]
        public ForecastDay[] Night { get; set; }
    }
}