


using CharlesApi.Entities.Siniestro;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Data.Siniestro
{
    public interface ISiniestroRepository
    {
        IList<SiniestroModel> ObtenerSiniestros();
        IList<SiniestroModel> BuscarSiniestros();
        SiniestroModel ObtenerSiniestro(SiniestroModel siniestroModel);
        SiniestroModel CrearSiniestro(SiniestroModel siniestroModel);
        bool ActualizarSiniestro(SiniestroModel siniestroModel);
        bool EliminarSiniestro();
    }
}