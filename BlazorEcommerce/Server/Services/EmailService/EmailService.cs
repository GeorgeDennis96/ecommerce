using Microsoft.AspNetCore.Hosting.Server;
using BlazorEcommerce.Shared.Models.Messaging;
using System.Net.Mail;
using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Server.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private SmtpClient SmtpServer { get; set; }
        private readonly string server = "smtp.gmail.com";
        private readonly string Username = ConfigManager.GetVariable("bot-username");
        public EmailService()
        {
            SmtpServer = new SmtpClient(server);
            SmtpServer.Credentials = new System.Net.NetworkCredential(Username, ConfigManager.GetVariable("bot-email-password"));
            SmtpServer.EnableSsl = true;
            SmtpServer.Port = 587;
        }

        public ServiceResponse<bool> SendEmail(Email email)
        {
            var response = new ServiceResponse<bool>() { Success = false };
            try
            {
                if (email != null)
                {
                    MailMessage mail = new MailMessage()
                    {
                        From = new MailAddress(Username),
                        Subject = email.Subject,
                        IsBodyHtml = true,
                        Body = $"<p>{email.Message}</p>"
                    };
                    mail.To.Add($"{email.To}");

                    SmtpServer.Send(mail);

                    response.Success = true;
                    return response;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
                return response;
            }
            return response;
        }
    }
}
