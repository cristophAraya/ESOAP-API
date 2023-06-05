using CharlesApi.Entities.Cobertura;

namespace CharlesApi.Repository.Cobertura
{
    public  interface ICoberturaRepository
    {
        CoberturaModel ObtenerCobertura(CoberturaModel coberturaModel);
    }
}