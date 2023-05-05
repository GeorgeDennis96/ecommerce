using BlazorEcommerce.Shared.Models.Messaging;

namespace BlazorEcommerce.Server.Services.EmailService
{
    public interface IEmailService
    {
        bool SendEmail(Email email);
    }
}
