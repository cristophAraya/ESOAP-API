using Cl.Sura.ESoapApi.Helpers.Base;
using System;

namespace Cl.Sura.ESoapApi.Helpers.Base
{
    public interface ISettingsConfig
    {
        public SendgridProfile SendgridProfile { get; set; }
        public SMTPProfile SMTPProfile { get; set; }
        public DapperProfile DapperProfile { get; set; }
        public JWTProfile JWTProfile { get; set; }

        public RemoteConnectProfile RemoteConnectProfile { get; set; }
        public string MailsTemplatePath { get; set; }
        public string UploadPath { get; set; }
        public AWSProfile AWSProfile { get; set; }

        public string UrlApiYpurMarket { get; set; }
        public string ApiKeyYouMarket { get; set; }
        public string ClientIdYouMarket { get; set; }
    }


    public class SettingsConfig : ISettingsConfig
    {
        public SendgridProfile SendgridProfile { get; set; }
        public DapperProfile DapperProfile { get; set; }
        public RemoteConnectProfile RemoteConnectProfile { get; set; }
        public JWTProfile JWTProfile { get; set; }
        public SMTPProfile SMTPProfile { get; set; }
        public string MailsTemplatePath { get; set; }
        public string UploadPath { get; set; }
        public AWSProfile AWSProfile { get; set; }
        public string UrlApiYpurMarket { get; set; }
        public string ApiKeyYouMarket { get; set; }
        public string ClientIdYouMarket { get; set; }

    }

}
