using Cl.Sura.ESoapApi.Models.Entities.ConsultaPoliza;


namespace Cl.Sura.ESoapApi.Data.Poliza
{
    public interface IPolizaRepository
    {
        ConsultaPolizaModel ConsultaPoliza(string numeroPoliza);
    }
}