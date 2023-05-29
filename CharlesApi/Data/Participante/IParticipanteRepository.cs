using CharlesApi.Entities.Participante;

namespace CharlesApi.Repository.Participante
{
    public interface IParticipanteRepository
    {
        IList<ParticipanteModel> ObtenerParticipantes();
        IList<ParticipanteModel> BuscarParticipantes();
        IList<ParticipanteModel> ObtenerParticipante();

        ParticipanteModel CrearParticipante(ParticipanteModel participanteModel);
        bool ActualizarParticipante(ParticipanteModel participanteModel);

        ParticipanteModel ObtenerParticipante(ParticipanteModel participanteModel);
    }
}