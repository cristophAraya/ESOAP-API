using CharlesApi.Entities.SiniestroLog;

namespace CharlesApi.Repository.SiniestroLog
{
    public interface ISiniestroLogRepository
    {
        IList<SiniestroLogModel> ObtenerSiniestroLogs();
        IList<SiniestroLogModel> BuscarSiniestroLogs();
        SiniestroLogModel ObtenerSiniestroLog();
        SiniestroLogModel CrearSiniestroLog(SiniestroLogModel SiniestroLogModel);
        bool ActualizarSiniestroLog(SiniestroLogModel SiniestroLogModel);
        bool EliminarSiniestroLog();
    }
}