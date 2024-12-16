using System;
using System.Collections.Generic;

namespace AITrading.Core.Models
{
    public class MarketData
    {
        public DateTime Timestamp { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get; set; }
        public string Symbol { get; set; }
    }
}