using Cl.Sura.ESoapApi.Models.Entities.ConsultaSiniestro;


namespace Cl.Sura.ESoapApi.Data.ConsultaSiniestro
{
    public interface IConsultaSiniestroRepository
    {
        ConsultaSiniestroModel ConsultaSiniestro(long claimNo);
    }
}