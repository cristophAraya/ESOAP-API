
namespace Cl.Sura.ESoapApi.Helpers.Base
{
    public class SendgridProfile : ISendgridProfile
    {
        public string Server { get; set; }
        public string Action { get; set; }
        public string ApiKey { get; set; }
        public string From { get; set; }
        public string TemplateId { get; set; }
    }

    public interface ISendgridProfile
    {
        string Server { get; set; }
        string Action { get; set; }
        string ApiKey { get; set; }
        string From { get; set; }
        string TemplateId { get; set; }
    }
}
