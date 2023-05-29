


using CharlesApi.Entities.CoberturaSiniestrada;
using CharlesApi.Request.CoberturaSiniestrada;
using CharlesApi.Result.CoberturaSiniestrada;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Data.CoberturaSiniestrada
{
    public interface ICoberturaSiniestradaService
    {
        ListadoCoberturaSiniestradaResult ObtenerCoberturaSiniestradas();
        ListadoCoberturaSiniestradaResult BuscarCoberturaSiniestradas();
        CoberturaSiniestradaResult ObtenerCoberturaSiniestrada(CoberturaSiniestradaRequest coberturaSiniestradaRequest);
        CoberturaSiniestradaResult CrearCoberturaSiniestrada(CoberturaSiniestradaRequest coberturaSiniestradaRequest);
        CoberturaSiniestradaResult ActualizarCoberturaSiniestrada(CoberturaSiniestradaRequest coberturaSiniestradaRequest);
        CoberturaSiniestradaResult EliminarCoberturaSiniestrada();



    }
}