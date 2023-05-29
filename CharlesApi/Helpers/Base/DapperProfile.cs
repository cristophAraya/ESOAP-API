
namespace CharlesApi.Helpers.Base
{
    public class DapperProfile : IDapperProfile
    {
        public string ConnectionString { get; set; }
        public string ConnectionStringPaso { get; set; }
    }

    public interface IDapperProfile
    {
        string ConnectionString { get; set; }
        public string ConnectionStringPaso { get; set; }
    }
}
