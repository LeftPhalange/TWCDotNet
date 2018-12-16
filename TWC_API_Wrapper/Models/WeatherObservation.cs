using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace TWC_API_Wrapper
{
    public class WeatherObservation
    {
        [JsonProperty("vt1observation")]
        public Observation ObservationData { get; set; }
    }
    public class Observation
    {
        [JsonProperty("altimeter")]
        public double Altimeter { get; set; }
        [JsonProperty("barometerTrend")]
        public string BarometerTrend { get; set; }
        [JsonProperty("barometerCode")]
        public int BarometerCode { get; set; }
        [JsonProperty("barometerChange")]
        public double BarometerChange { get; set; }
        [JsonProperty("dewPoint")]
        public int DewPoint { get; set; }
        [JsonProperty("feelsLike")]
        public int FeelsLike { get; set; }
        [JsonProperty("gust")]
        public int Gusts { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("observationTime")]
        public string ObservationTime { get; set; }
        [JsonProperty("obsQualifierCode")]
        public string ObsQualifierCode { get; set; }
        [JsonProperty("obsQualifierSeverity")]
        public string ObsQualifierSeverity { get; set; }
        [JsonProperty("phrase")]
        public string Phrase { get; set; }
        [JsonProperty("precip24Hour")]
        public double Precip24Hour { get; set; }
        [JsonProperty("snowDepth")]
        public double SnowDepth { get; set; }
        [JsonProperty("temperature")]
        public int Temperature { get; set; }
        [JsonProperty("temperatureMaxSince7am")]
        public int TemperatureMaxSince7am { get; set; }
        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }
        [JsonProperty("uvDescription")]
        public string UvDescription { get; set; }
        [JsonProperty("visibility")]
        public double Visibility { get; set; }
        [JsonProperty("windSpeed")]
        public int WindSpeed { get; set; }
        [JsonProperty("windDirCompass")]
        public string WindDirCompass { get; set; }
        [JsonProperty("windDirDegrees")]
        public int WindDirDegrees { get; set; }
    }
}