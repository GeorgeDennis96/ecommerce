using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models.Messaging;

namespace BlazorEcommerce.Server.Services.EmailService
{
    public interface IEmailService
    {
        ServiceResponse<bool> SendEmail(Email email);
    }
}
