using CharlesApi.Request.SiniestroLog;
using CharlesApi.Result.SiniestroLog;

namespace CharlesApi.Data.SiniestroLog
{
    public interface ISiniestroLogService
    {
        ListadoSiniestroLogResult ObtenerSiniestroLogs();
        ListadoSiniestroLogResult BuscarSiniestroLogs();
        SiniestroLogResult ObtenerSiniestroLog();
        SiniestroLogResult CrearSiniestroLog(SiniestroLogRequest SiniestroLogRequest);
        SiniestroLogResult ActualizarSiniestroLog(SiniestroLogRequest SiniestroLogRequest);
        SiniestroLogResult EliminarSiniestroLog();
    }
}