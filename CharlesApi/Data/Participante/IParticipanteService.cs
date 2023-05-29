using CharlesApi.Request.Participante;
using CharlesApi.Result.Participante;

namespace CharlesApi.Data.Participante
{
    public interface IParticipanteService
    {
        ListadoParticipanteResult ObtenerParticipantes();
        ListadoParticipanteResult BuscarParticipantes();
        ParticipanteResult ObtenerParticipante();
        ParticipanteResult CrearParticipante(ParticipanteRequest participanteRequest);
        ParticipanteResult ActualizarParticipante(ParticipanteRequest participanteRequest);

    }
}