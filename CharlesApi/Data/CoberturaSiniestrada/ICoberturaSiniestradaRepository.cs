


using CharlesApi.Entities.CoberturaSiniestrada;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Repository.CoberturaSiniestrada
{
    public interface ICoberturaSiniestradaRepository
    {
        IList<CoberturaSiniestradaModel> ObtenerCoberturaSiniestradas();
        IList<CoberturaSiniestradaModel> BuscarCoberturaSiniestradas(CoberturaSiniestradaModel coberturaSiniestradaModel);
        CoberturaSiniestradaModel ObtenerCoberturaSiniestrada(CoberturaSiniestradaModel coberturaSiniestradaModel);
        CoberturaSiniestradaModel CrearCoberturaSiniestrada(CoberturaSiniestradaModel coberturaSiniestradaModel);
        bool ActualizarCoberturaSiniestrada(CoberturaSiniestradaModel coberturaSiniestradaModel);
        bool EliminarCoberturaSiniestrada();
    }
}