using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TWCDotNet.Models__V3_
{
    public class HeadlinesV3
    {
        [JsonProperty("alerts")]
        public Alerts[] AlertMessages { get; set; }
        public class Alerts
        {
            [JsonProperty("headlineText")]
            public string HeadlineText { get; set; }
            [JsonProperty("expireTimeLocal")]
            public string ExpireDate { get; set; }
        }
    }
}
