﻿namespace OrderMatcher
{
    public class CancelledOrder
    {
        public OrderId OrderId { get; set; }
        public Quantity RemainingQuantity { get; set; }
        public Quantity Cost { get; set; }
        public Quantity Fee { get; set; }
        public CancelReason CancelReason { get; set; }
        public int Timestamp { get; set; }
    }
}
