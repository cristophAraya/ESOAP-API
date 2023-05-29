


using CharlesApi.Entities.TipoEvento;
/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


namespace CharlesApi.Repository.TipoEvento
{
    public interface ITipoEventoRepository
    {
        TipoEventoModel ObtenerTipoEvento(TipoEventoModel tipoEventoModel);
    }
}