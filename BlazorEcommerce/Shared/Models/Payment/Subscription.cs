
namespace BlazorEcommerce.Shared.Models.Payment
{
    public class Subscription
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? ProductName { get; set; }
        public bool IsCancelled { get; set; } = false;
        public bool IsPaused { get; set; } = false;
        public SubscriptionTypes? SubscriptionType { get; set; }
    }

    public class SubscriptionTypes
    {
        public static string OneTimePayment { get { return "onetime"; } }
        public static string RecurringPayment { get { return "recurring"; } }
        public static string RecurringMeteredPayment { get { return "metered"; } }

    }
}
