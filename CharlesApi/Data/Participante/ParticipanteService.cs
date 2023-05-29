






/**
* (c)2013-2023 CodeBase Todos los Derechos Reservados.
*
* El uso de este programa y/o la documentación asociada, ya sea en forma
* de fuentes o archivos binarios, con o sin modificaciones,
* esta sujeto a la licencia descrita en LICENCIA.TXT.
**/


/*
	*24-05-2023,Generador de Código, Clase Inicial 
*/



//using CharlesApi.Data.Base;
using AutoMapper;
using CharlesApi.Entities.Participante;
using CharlesApi.Helpers.Base;
using CharlesApi.Repository.Participante;
using CharlesApi.Request.Participante;
using CharlesApi.Result.Participante;


namespace CharlesApi.Data.Participante
{
	/// <summary>
	/// Esta Clase Participante  permite gestionar reglas de negocio asociados a la entidad Participante
	/// </summary>
	public partial class ParticipanteService : IParticipanteService
	{	
        private ISettingsConfig settings;
        private IParticipanteRepository participanteRepository;
        private IMapper mapper;
        public ParticipanteService(IParticipanteRepository participanteRepository, IMapper mapper)
        {
            this.participanteRepository = participanteRepository;
            this.mapper = mapper;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto ParticipanteResult con información del resultado de la operación</returns>
		public ListadoParticipanteResult ObtenerParticipantes()
		{
			ListadoParticipanteResult listadoParticipanteResult = new ListadoParticipanteResult();
            listadoParticipanteResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var participantes = participanteRepository.ObtenerParticipantes();
                listadoParticipanteResult.Participantes = new List<ParticipanteResult>();

                if (participantes != null)
                {
                    listadoParticipanteResult.Participantes = mapper.Map<IList<ParticipanteResult>>(participantes);
                    listadoParticipanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoParticipanteResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto ParticipanteResult con información del resultado de la operación</returns>
		public ListadoParticipanteResult BuscarParticipantes()
		{
			ListadoParticipanteResult listadoParticipanteResult = new ListadoParticipanteResult();
            listadoParticipanteResult.StatusCode = StatusCodes.Status204NoContent;
            try
            {
				var participantes = participanteRepository.BuscarParticipantes();
                listadoParticipanteResult.Participantes = new List<ParticipanteResult>();

                if (participantes != null)
                {
                    listadoParticipanteResult.Participantes = mapper.Map<IList<ParticipanteResult>>(participantes);
                    listadoParticipanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return listadoParticipanteResult;
		}

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <returns>Objeto ParticipanteResult con información del resultado de la operación</returns>
		public ParticipanteResult ObtenerParticipante()
        {
			ParticipanteResult participanteResult = new ParticipanteResult();
            participanteResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var participante = participanteRepository.ObtenerParticipante();
                if (participante!=null)
                {
                    participanteResult = mapper.Map<ParticipanteResult>(participante);
                    participanteResult.StatusCode = StatusCodes.Status200OK;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return participanteResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="participanteModel"></param>
		/// <returns>Objeto ParticipanteResult con información del resultado de la operación</returns>
		public ParticipanteResult CrearParticipante(ParticipanteRequest participanteRequest)
		{
			ParticipanteResult participanteResult = new ParticipanteResult();
            participanteResult.StatusCode = StatusCodes.Status202Accepted;
            try
            {
				var participante = mapper.Map<ParticipanteModel>(participanteRequest);
                participante = participanteRepository.CrearParticipante(participante);
                if (participante != null)
                {
                    participanteResult = mapper.Map<ParticipanteResult>(participante);
                    participanteResult.StatusCode = StatusCodes.Status201Created;
                }
			}
			catch (Exception e)
            {
                throw e;
            }
            return participanteResult;
        }

		/// <summary>
		/// Agrega un elemento desde el medio de persistencia
		/// </summary>
		/// <param name="participanteModel"></param>
		/// <returns>Objeto ParticipanteResult con información del resultado de la operación</returns>
		public ParticipanteResult ActualizarParticipante(ParticipanteRequest participanteRequest)
		{
			ParticipanteResult participanteResult = new ParticipanteResult();
            participanteResult.StatusCode = StatusCodes.Status202Accepted;
			try
			{
				var participante = mapper.Map<ParticipanteModel>(participanteRequest);
                var result = participanteRepository.ActualizarParticipante(participante);
                if (result)
                {
                    participanteResult.StatusCode = StatusCodes.Status204NoContent;
                }
			}
            catch (Exception e)
            {
                throw e;
            }
            return participanteResult;
		}

	}
}

