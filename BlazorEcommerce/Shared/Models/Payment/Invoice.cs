
namespace BlazorEcommerce.Shared.Models.Payment
{
    public class Invoice
    {
        public string? CustomerId { get; set; }
        public DateTime? DueDate { get; set; }
        public List<string>? DiscountIds { get; set; }
        public decimal TaxRate { get; set; }
        public string? Currency { get; set; }
        public Dictionary<string, string>? Metadata { get; set; }
    }
}
