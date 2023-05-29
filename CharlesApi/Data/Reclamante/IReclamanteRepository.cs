


using CharlesApi.Entities.Reclamante;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Repository.Reclamante
{
    public interface IReclamanteRepository
    {
        IList<ReclamanteModel> ObtenerReclamantes();
        IList<ReclamanteModel> BuscarReclamantes(ReclamanteModel reclamanteModel);
        ReclamanteModel ObtenerReclamante(ReclamanteModel reclamanteModel);
        ReclamanteModel CrearReclamante(ReclamanteModel reclamanteModel);
        bool ActualizarReclamante(ReclamanteModel reclamanteModel);
        bool EliminarReclamante();
    }
}