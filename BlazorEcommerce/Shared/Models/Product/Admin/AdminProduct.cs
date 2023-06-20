using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEcommerce.Shared.Models.Product.Admin
{
    public class AdminProduct
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        [Column(TypeName = "Decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
