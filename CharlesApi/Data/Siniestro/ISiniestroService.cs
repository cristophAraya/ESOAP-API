


using CharlesApi.Request.Siniestro;
using CharlesApi.Result.Siniestro;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Data.Siniestro
{
    public interface ISiniestroService
    {
        ListadoSiniestroResult ObtenerSiniestros();
        ListadoSiniestroResult BuscarSiniestros();
        SiniestroResult ObtenerSiniestro();
        SiniestroResult CrearSiniestro(SiniestroRequest siniestroRequest);
        SiniestroResult ActualizarSiniestro(SiniestroRequest siniestroRequest);
        SiniestroResult EliminarSiniestro();
    }
}