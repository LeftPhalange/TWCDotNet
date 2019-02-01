using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TWCDotNet.Models__V1_
{
    public class Alerts // this is modeled as an array itself
    {
        [JsonProperty("detailKey")]
        public string DetailKey { get; set; }
        [JsonProperty("messageTypeCode")]
        public int? MessageTypeCode { get; set; }
        [JsonProperty("messageType")]
        public string MessageType { get; set; }
        [JsonProperty("productIdentifier")]
        public string ProductIdentifier { get; set; }
        [JsonProperty("phenomena")]
        public string Phenomena { get; set; }
        [JsonProperty("significance")]
        public string Significance { get; set; }
        [JsonProperty("eventTrackingNumber")]
        public string EventTrackingNumber { get; set; }
    }
}