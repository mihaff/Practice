using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Practice.Utils.Converters;

namespace Practice.Models
{
    public class TradedTicker
    {
        public string Ticker { get; set; }

        [JsonConverter(typeof(DoubleJsonConverter))]
        public double Price { get; set; }

        [JsonPropertyName("change_amount")]
        public string Change_Amount { get; set; }

        [JsonPropertyName("change_percentage")]
        public string Change_Percentage { get; set; }

        [JsonConverter(typeof(IntJsonConverter))]
        public int Volume { get; set; }
    }

}
