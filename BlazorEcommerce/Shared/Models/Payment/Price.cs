
namespace BlazorEcommerce.Shared.Models.Payment
{
    public class Price
    {
        // The product this price is attached to
        public string ProductId { get; set; }
        public string? Nickname { get; set; }
        public string? CurrencyType { get; set; }
        public long Amount { get; set; }
        public bool IsActive { get; set; }

        // recurring or one_time
        public string? Type { get; set; }

        // day, week, month or year
        public IntervalTypes? Interval { get; set; }
        public string? IntervalCount { get; set; }
        public string? AggregateUsage { get; set; }
        public bool IsDefaultPrice { get; set; }
        public string? PriceId { get; set; }

    }

    public class IntervalTypes
    {
        public static string Day { get { return "day"; } }
        public static string Month { get { return "month"; } }
        public static string Year { get { return "year"; } }

    }
}
