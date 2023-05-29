


using CharlesApi.Entities.Reclamante;
using CharlesApi.Request.Reclamante;
using CharlesApi.Result.Reclamante;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Data.Reclamante
{
    public interface IReclamanteService
    {
        ListadoReclamanteResult ObtenerReclamantes();
        ListadoReclamanteResult BuscarReclamantes();
        ReclamanteResult ObtenerReclamante(ReclamanteModel reclamanteModel);
        ReclamanteResult CrearReclamante(ReclamanteRequest reclamanteRequest);
        ReclamanteResult ActualizarReclamante(ReclamanteRequest reclamanteRequest);
        ReclamanteResult EliminarReclamante();
    }
}