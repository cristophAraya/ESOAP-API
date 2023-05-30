using CharlesApi.Helpers.Base;
using System;

namespace CharlesApi.Helpers.Base
{
    public interface ISettingsConfig
    {
        public string UrlBaseEsoapApi {get;set;}
        public SMTPProfile SMTPProfile { get; set; }
        public DapperProfile DapperProfile { get; set; }
        public JWTProfile JWTProfile { get; set; }

        public RemoteConnectProfile RemoteConnectProfile { get; set; }
        public string MailsTemplatePath { get; set; }
        public string UploadPath { get; set; }

    }


    public class SettingsConfig : ISettingsConfig
    {
        public string UrlBaseEsoapApi { get; set; }
        public DapperProfile DapperProfile { get; set; }
        public RemoteConnectProfile RemoteConnectProfile { get; set; }
        public JWTProfile JWTProfile { get; set; }
        public SMTPProfile SMTPProfile { get; set; }
        public string MailsTemplatePath { get; set; }
        public string UploadPath { get; set; }  

    }

}
