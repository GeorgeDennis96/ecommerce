using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerce.Shared.Models.Messaging
{
    public class Email
    {
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? To { get; set; }
        [Required]
        public string? From { get; set; }
        [Required]
        public string? Message { get; set; }
    }
}
