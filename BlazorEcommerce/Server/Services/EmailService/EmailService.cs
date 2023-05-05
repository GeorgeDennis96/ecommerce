using Microsoft.AspNetCore.Hosting.Server;
using BlazorEcommerce.Shared.Models.Messaging;
using System.Net.Mail;

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

        public bool SendEmail(Email email)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(Username);
                mail.To.Add(email.To);
                mail.Subject = email.Subject;
                mail.IsBodyHtml = true;
                mail.Body =
                    $"<p>{email.Message}</p>";

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
                return false;
            }
        }
    }
}
