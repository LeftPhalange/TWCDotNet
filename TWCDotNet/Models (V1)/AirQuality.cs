using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TWCDotNet.Models__V1_
{
    public class AirQuality
    {
        [JsonProperty("airquality")]
        public AirQualityData[] AirQualityInfo { get; set; }
    }
    public class AirQualityData
    {
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("area_id")]
        public string Area_ID { get; set; }
        [JsonProperty("area_name")]
        public string Area_Name { get; set; }
        [JsonProperty("state_cd")]
        public string State_Code { get; set; }
        [JsonProperty("country_cd")]
        public string Country_Code { get; set; }
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("rpt_dt")]
        public string ReportedDateTime { get; set; }
        [JsonProperty("valid_time_lap")]
        public string ValidTime { get; set; }
        [JsonProperty("process_time_gmt")]
        public long? ProcessTimeEpoch { get; set; } // in GMT
        [JsonProperty("action_day_ind")]
        public string Action_Day { get; set; }
        [JsonProperty("air_quality_cmnt")]
        public string AirQualityComment { get; set; }
        [JsonProperty("data_type")]
        public string Data_Type { get; set; }
        [JsonProperty("pollutants")]
        public Pollutants[] pollutants { get; set; }
    }
    public class Pollutants
    {
        [JsonProperty("primary_pollutant_ind")]
        public string Primary_Pollutant_Indicator { get; set; }
        [JsonProperty("pollutant")]
        public string Pollutant { get; set; }
        [JsonProperty("pollutant_phrase")]
        public string Pollutant_Phrase { get; set; }
        [JsonProperty("air_quality_idx")]
        public int? Air_Quality_Index { get; set; }
        [JsonProperty("air_quality_cat")]
        public string Air_Quality_Category { get; set; }
        [JsonProperty("air_quality_cat_idx")]
        public int? Air_Quality_Category_Index { get; set; }
    }
}
