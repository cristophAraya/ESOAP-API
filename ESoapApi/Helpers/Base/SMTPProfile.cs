namespace Cl.Sura.ESoapApi.Helpers.Base
{
    public class SMTPProfile : ISMTPProfile
    {
        public string SmtpServer { get; set; }
        public string SmtpPort { get; set; }
        public bool IsSSL { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpSender { get; set; }
    }

    public interface ISMTPProfile
    {
        string SmtpServer { get; set; }
        string SmtpPort { get; set; }
        public bool IsSSL { get; set; }
        string SmtpUser { get; set; }
        string SmtpPassword { get; set; }
        string SmtpSender { get; set; }
    }
}
