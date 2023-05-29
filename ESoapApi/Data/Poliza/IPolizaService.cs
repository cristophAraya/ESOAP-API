using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;

namespace Cl.Sura.ESoapApi.Data.Poliza
{
    public interface IPolizaService
    {
        ConsultaPolizaResult ConsultaPoliza(string numeroPoliza);
    }
}