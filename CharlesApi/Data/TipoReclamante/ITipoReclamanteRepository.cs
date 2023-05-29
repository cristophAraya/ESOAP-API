using CharlesApi.Entities.TipoReclamante;

namespace CharlesApi.Repository.TipoReclamante
{
    public interface ITipoReclamanteRepository
    {
        TipoReclamanteModel ObtenerTipoReclamante(TipoReclamanteModel tipoReclamanteModel);
    }
}