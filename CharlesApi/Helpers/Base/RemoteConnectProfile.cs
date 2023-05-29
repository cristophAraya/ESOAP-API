
namespace CharlesApi.Helpers.Base
{
    public class RemoteConnectProfile : IRemoteConnectProfile
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
    }

    public interface IRemoteConnectProfile
    {
        string User { get; set; }
        string Password { get; set; }
        string Url { get; set; }
    }
}
