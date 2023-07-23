using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Practice.Models
{
    public class TradedTickerStatistics
    {
        public string Metadata { get; set; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("top_gainers")]
        public List<TradedTicker> TopGainers { get; set; }

        [JsonPropertyName("top_losers")]
        public List<TradedTicker> TopLosers { get; set; }

        [JsonPropertyName("most_actively_traded")]
        public List<TradedTicker> MostActivelyTraded { get; set; }
    }
}
