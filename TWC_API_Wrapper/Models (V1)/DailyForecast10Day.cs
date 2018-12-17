using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TWCDotNet.Models__V1_
{
    public class DailyForecast10Day
    {
        [JsonProperty("fod_long_range_daily")]
        public string Class { get; set; }
        [JsonProperty("expire_time_gmt")]
        public string ExpireTimeGMT { get; set; }
        [JsonProperty("fcst_valid")]
        public long? ForecastValid { get; set; }
        [JsonProperty("fcst_valid_local")]
        public string ForecastValidLocal { get; set; }
        [JsonProperty("num")]
        public int? Num { get; set; }
        [JsonProperty("max_temp")]
        public int? MaxTemperature { get; set; }
        [JsonProperty("min_temp")]
        public int? MinimumTemperature { get; set; }
        [JsonProperty("torcon")]
        public object TORCONValue { get; set; }
        [JsonProperty("stormcon")]
        public object STORMCONValue { get; set; }
        [JsonProperty("blurb")]
        public object Blurb { get; set; }
        [JsonProperty("blurb_author")]
        public object Blurb_Author { get; set; }
        [JsonProperty("lunar_phase_day")]
        public int? LunarPhaseDay { get; set; }
        [JsonProperty("dow")]
        public string DayOfWeek { get; set; }
        [JsonProperty("lunar_phase")]
        public string LunarPhase { get; set; }
        [JsonProperty("lunar_phase_code")]
        public string LunarPhaseCode { get; set; }
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }
        [JsonProperty("sunset")]
        public string Sunset { get; set; }
        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }
        [JsonProperty("moonset")]
        public string Moonset { get; set; }
        [JsonProperty("qualifier_code")]
        public object QualifierCode { get; set; }
        [JsonProperty("qualifier")]
        public object Qualifier { get; set; }
        [JsonProperty("narrative")]
        public string Narrative { get; set; }
        [JsonProperty("qpf")]
        public double? QPF { get; set; }
        [JsonProperty("snow_qpf")]
        public double? SnowQPF { get; set; }
        [JsonProperty("snow_range")]
        public string SnowRange { get; set; }
        [JsonProperty("snow_phrase")]
        public string SnowPhrase { get; set; }
        [JsonProperty("snow_code")]
        public string SnowCode { get; set; }
        [JsonProperty("day")]
        public DailyModel Day { get; set; }
        [JsonProperty("night")]
        public DailyModel Night { get; set; }
        public class DailyModel
        {
            [JsonProperty("fcst_valid")]
            public long? ForecastValidEpoch { get; set; }
            [JsonProperty("fcst_valid_local")]
            public string ForecastValidString { get; set; }
            [JsonProperty("day_ind")]
            public string DayIndication { get; set; }
            [JsonProperty("thunder_enum")]
            public int? ThunderEnumeration { get; set; }
            [JsonProperty("daypart_name")]
            public string DaypartName { get; set; }
            [JsonProperty("long_daypart_name")]
            public string LongDaypartName { get; set; }
            [JsonProperty("alt_daypart_name")]
            public string AlternateDaypartName { get; set; }
            [JsonProperty("thunder_enum_phrase")]
            public long? ThunderEnumerationPhrase { get; set; }
            [JsonProperty("num")]
            public int Num { get; set; }
            [JsonProperty("temp")]
            public int? Temperature { get; set; }
            [JsonProperty("hi")]
            public int? HeatIndex { get; set; }
            [JsonProperty("wc")]
            public int? WindChill { get; set; }
            [JsonProperty("pop")]
            public int? ProbabilityOfPrecipitation { get; set; }
            [JsonProperty("icon_extd")]
            public int? IconExtended { get; set; }
            [JsonProperty("icon_code")]
            public int? IconCode { get; set; }
            [JsonProperty("wxman")]
            public string WXMan { get; set; }
            [JsonProperty("phrase_12char")]
            public string Phrase_12Char { get; set; }
            [JsonProperty("phrase_22char")]
            public string Phrase_22Char { get; set; }
            [JsonProperty("phrase_32char")]
            public string Phrase_32Char { get; set; }
            [JsonProperty("subphrase_pt1")]
            public string Subphrase_Part1 { get; set; }
            [JsonProperty("subphrase_pt2")]
            public string Subphrase_Part2 { get; set; }
            [JsonProperty("subphrase_pt3")]
            public string Subphrase_Part3 { get; set; }
            [JsonProperty("precip_type")]
            public string PrecipType { get; set; }
            [JsonProperty("rh")]
            public int? RelativeHumidity { get; set; }
            [JsonProperty("wspd")]
            public int? WindSpeed { get; set; }
            [JsonProperty("wdir")]
            public int? WindDirection { get; set; }
            [JsonProperty("wdir_cardinal")]
            public string WindDirection_Cardinal { get; set; }
            [JsonProperty("clds")]
            public int? Clds { get; set; }
            [JsonProperty("pop_phrase")]
            public string Pop_Phrase { get; set; }
            [JsonProperty("temp_phrase")]
            public string Temp_Phrase { get; set; }
            [JsonProperty("accumulation_phrase")]
            public string AccumulationPhrase { get; set; }
            [JsonProperty("wind_phrase")]
            public string WindPhrase { get; set; }
            [JsonProperty("shortcast")]
            public string Shortcast { get; set; }
            [JsonProperty("narrative")]
            public string Narrative { get; set; }
            [JsonProperty("qpf")]
            public int? QPF { get; set; }
            [JsonProperty("snow_qpf")]
            public int? Snow_QPF { get; set; }
            [JsonProperty("snow_range")]
            public string Snow_Range { get; set; }
            [JsonProperty("snow_phrase")]
            public string Snow_Phrase { get; set; }
            [JsonProperty("snow_code")]
            public string Snow_Code { get; set; }
            [JsonProperty("vocal_key")]
            public string VocalKey { get; set; }
            [JsonProperty("qualifier_code")]
            public object QualifierCode { get; set; }
            [JsonProperty("qualifier")]
            public object Qualifier { get; set; }
            [JsonProperty("uv_index_raw")]
            public int? UV_Index_Raw { get; set; }
            [JsonProperty("uv_index")]
            public int? UV_Index { get; set; }
            [JsonProperty("uv_warning")]
            public int? UV_Warning { get; set; }
            [JsonProperty("uv_desc")]
            public string UV_Desc { get; set; }
            [JsonProperty("golf_index")]
            public string GolfIndex { get; set; }
            [JsonProperty("golf_category")]
            public string GolfCategory { get; set; }
        }
    }
}