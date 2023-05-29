
using Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro;


namespace Cl.Sura.ESoapApi.Data.ConsultaSiniestro
{
    public interface IConsultaSiniestroService
    {
        ConsultaSiniestroResult ConsultaSiniestro(long claimNo);
    }
}