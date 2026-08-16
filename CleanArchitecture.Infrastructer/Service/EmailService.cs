using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace CleanArchitecture.Infrastructer.Service
{
    public static class EmailService
    {
        public static async Task SendEmailAsync(SendEmailModel model)
        {
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse(model.Email));

            foreach (var to in model.Emails)
                message.To.Add(MailboxAddress.Parse(to));

            message.Subject = model.Subject;

            var builder = new BodyBuilder();
            if (model.Html)
                builder.HtmlBody = model.body;
            else
                builder.TextBody = model.body;

            if (model.Attachments is not null)
            {
                foreach (var attachment in model.Attachments)
                    builder.Attachments.Add(attachment.Name, attachment.ContentStream);
            }

            message.Body = builder.ToMessageBody();

            using var client = new SmtpClient();
            await client.ConnectAsync(
                model.Smtp,
                model.Port,
                model.SSL ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTls);

            await client.AuthenticateAsync(model.Email, model.Password);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}
