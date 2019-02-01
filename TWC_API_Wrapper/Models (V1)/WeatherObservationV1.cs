using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TWCDotNet.Models__V1_
{
    public class WeatherObservationV1
    {
        [JsonProperty("observation")]
        public Observation ObservationData { get; set; }
    }
    public class Observation
    {
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("expire_time_gmt")]
        public string ExpireTimeGMT { get; set; }
        [JsonProperty("obs_time")]
        public string ObsTime { get; set; }
        [JsonProperty("obs_time_local")]
        public string ObsTimeLocal { get; set; }
        [JsonProperty("wdir")]
        public int? WindDirection { get; set; }
        [JsonProperty("icon_code")]
        public int? IconCode { get; set; }
        [JsonProperty("icon_extd")]
        public int? IconExtended { get; set; }
        [JsonProperty("sunrise")]
        public string SunriseDateTime { get; set; }
        [JsonProperty("sunset")]
        public string SunsetDateTime { get; set; }
        [JsonProperty("day_ind")]
        public string DayIndicator { get; set; }
        [JsonProperty("uv_index")]
        public int? UVIndex { get; set; }
        [JsonProperty("uv_warning")]
        public int? UVWarning { get; set; }
        [JsonProperty("obs_qualifier_code")]
        public string ObsQualifierCode { get; set; }
        [JsonProperty("ptend_code")]
        public int? PTendCode { get; set; }
        [JsonProperty("dow")]
        public string DayOfWeek { get; set; }
        [JsonProperty("wdir_cardinal")]
        public string WindDirection_Cardinal { get; set; }
        [JsonProperty("phrase_12char")]
        public string Phrase12Char { get; set; }
        [JsonProperty("phrase_22char")]
        public string Phrase22Char { get; set; }
        [JsonProperty("phrase_32char")]
        public string Phrase32Char { get; set; }
        [JsonProperty("ptend_desc")]
        public string PTend_Desc { get; set; }
        [JsonProperty("sky_cover")]
        public string SkyCover { get; set; }
        [JsonProperty("clds")]
        public string CloudCover { get; set; }
        [JsonProperty("obs_qualifier_severity")]
        public int? ObsQualifierSeverity { get; set; }
        [JsonProperty("vocal_key")]
        public string VocalKey { get; set; }
        [JsonProperty("imperial")]
        public Imperial Imperial { get; set; }
    }
    public class Imperial
    {
        [JsonProperty("wspd")]
        public int? WindSpeed { get; set; }
        [JsonProperty("gust")]
        public int? WindGusts { get; set; }
        [JsonProperty("vis")]
        public double? Visibility { get; set; }
        [JsonProperty("mslp")]
        public double? AltimeterMb { get; set; }
        [JsonProperty("altimeter")]
        public double? AltimeterIn { get; set; }
        [JsonProperty("temp")]
        public int? Temperature { get; set; }
        [JsonProperty("dewpt")]
        public int? Dewpoint { get; set; }
        [JsonProperty("rh")]
        public int? RelativeHumidity { get; set; }
        [JsonProperty("wc")]
        public int? WindChill { get; set; }
        [JsonProperty("hi")]
        public int? HeatIndex { get; set; }
        [JsonProperty("temp_change_24hour")]
        public int? TempChange24Hour { get; set; }
        [JsonProperty("temp_max_24hour")]
        public int? TempMax24Hour { get; set; }
        [JsonProperty("temp_min_24hour")]
        public int? TempMin24Hour { get; set; }
        [JsonProperty("pchange")]
        public double? PChange { get; set; }
        [JsonProperty("feels_like")]
        public int? FeelsLike { get; set; }
        [JsonProperty("snow_1hour")]
        public double? Snow_1Hour { get; set; }
        [JsonProperty("snow_6hour")]
        public double? Snow_6Hour { get; set; }
        [JsonProperty("snow_24hour")]
        public double? Snow_24Hour { get; set; }
        [JsonProperty("snow_mtd")]
        public double? Snow_MonthToDate { get; set; }
        [JsonProperty("snow_season")]
        public double? Snow_Season { get; set; }
        [JsonProperty("snow_ytd")]
        public double? Snow_YearToDate { get; set; }
        [JsonProperty("snow_2day")]
        public double? Snow_2Day { get; set; }
        [JsonProperty("snow_3day")]
        public double? Snow_3Day { get; set; }
        [JsonProperty("snow_7day")]
        public double? Snow_7Day { get; set; }
        [JsonProperty("ceiling")]
        public int? Ceiling { get; set; }
        [JsonProperty("precip_1hour")]
        public double? Precip_1Hour { get; set; }
        [JsonProperty("precip_6hour")]
        public double? Precip_6Hour { get; set; }
        [JsonProperty("precip_24hour")]
        public double? Precip_24Hour { get; set; }
        [JsonProperty("precip_mtd")]
        public double? Precip_MonthToDate { get; set; }
        [JsonProperty("precip_ytd")]
        public double? Precip_YearToDate { get; set; }
        [JsonProperty("precip_2day")]
        public double? Precip_2Day { get; set; }
        [JsonProperty("precip_3day")]
        public double? Precip_3Day { get; set; }
        [JsonProperty("precip_7day")]
        public double? Precip_7Day { get; set; }
        [JsonProperty("obs_qualifier_100char")]
        public string ObsQualifier100Char { get; set; }
        [JsonProperty("obs_qualifier_50char")]
        public string ObsQualifier50Char { get; set; }
        [JsonProperty("obs_qualifier_32char")]
        public string ObsQualifier32Char { get; set; }
    }
}
