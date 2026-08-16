using CleanArchitecture.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructer.Service
{
    public sealed class MailService : IMailService
    {
        public async Task SendMailAsync(List<string> emails, string subject, string body, List<Attachment> attachments)
        {
            SendEmailModel sendEmailModel = new()
            {
                body = body,
                Emails = emails,
                Email = "",
                Html = true,
                Password = "",
                Port = 587,
                Smtp = "",
                SSL = true,
                Subject = subject,
                Attachments = attachments
            };
            await EmailService.SendEmailAsync(sendEmailModel);
            

        }

       
    }
}
