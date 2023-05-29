namespace Cl.Sura.ESoapApi.Helpers.Base
{
    public class JWTProfile : IJWTProfile
    {
        public string SecretKey { get; set; }
        public string AudienceToken { get; set; }
        public string IssuerToken { get; set; }
        public string ExpireTime { get; set; }
    }

    public interface IJWTProfile
    {
        string SecretKey { get; set; }
        string AudienceToken { get; set; }
        string IssuerToken { get; set; }
        string ExpireTime { get; set; }
    }
}
