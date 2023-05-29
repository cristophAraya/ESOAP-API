using System;
using System.Security.Authentication;

namespace CharlesApi.Helpers.Base
{
    public class DBBaseHelper : BaseHelper
    {
        protected ISettingsConfig settingsConfig = null;

        public DBBaseHelper(ISettingsConfig settingsConfig)
        {
            this.settingsConfig = settingsConfig;
        }     

        public IDapperProfile GetDBConnectionInfo()
        {
            return settingsConfig.DapperProfile;
        }

        public string GetDatabase()
        {
            return GetDBConnectionInfo().ConnectionString;
        }

        public string GetDatabasePaso()
        {
            return GetDBConnectionInfo().ConnectionStringPaso;
        }

    }
}