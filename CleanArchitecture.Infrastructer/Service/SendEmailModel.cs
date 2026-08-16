using System.Net.Mail;

namespace CleanArchitecture.Infrastructer.Service
{
    public sealed class SendEmailModel
    {
        public string body { get; set; }
        public List<string> Emails { get; set; }
        public string Email { get; set; }
        public bool Html { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string Smtp { get; set; }
        public bool SSL { get; set; }
        public string Subject { get; set; }
        public List<Attachment> Attachments { get; set; }
        public SendEmailModel() { }

    }
}