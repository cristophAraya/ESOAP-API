using AutoMapper;
using Cl.Propal.Sincronizacion.Helpers.Producers;
using Cl.Sura.ESoapApi.Data.Persona;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.CreaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersona;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPersonaCompleta;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;
using Cl.Sura.ESoapApi.Models.Result.CreaPersona;

namespace Cl.Sura.ESoapApi.Data.Poliza
{
    public class PersonaService : IPersonaService
    {
        private ISettingsConfig settings;
        private IPersonaRepository personaRepository;
        private IMapper mapper;
        public PersonaService(IPersonaRepository personaRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.personaRepository = personaRepository;
            this.mapper = mapper;
        }

        public ConsultaPersonaResult ConsultaPersona(string egn)
        {
            ConsultaPersonaResult consultaPoliza = new ConsultaPersonaResult();
            consultaPoliza.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var poliza = personaRepository.ConsultaPersona(egn);
                if (poliza != null)
                {
                    consultaPoliza = mapper.Map<ConsultaPersonaResult>(poliza);
                    consultaPoliza.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return consultaPoliza;
        }

        public ConsultaPersonaCompletaResult ConsultaPersonaCompleta(string egn)
        {
            ConsultaPersonaCompletaResult consultaPoliza = new ConsultaPersonaCompletaResult();
            consultaPoliza.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var poliza = personaRepository.ConsultaPersonaCompleta(egn);
                if (poliza != null)
                {
                    consultaPoliza = mapper.Map<ConsultaPersonaCompletaResult>(poliza);
                    consultaPoliza.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return consultaPoliza;
        }

        public CreaPersonaResult CrearPersona(CreaPersonaRequest personaRequest)
        {
            CreaPersonaResult consultaPoliza = new CreaPersonaResult();
            consultaPoliza.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var poliza = personaRepository.CreaPersona(personaRequest);
                if (poliza != null)
                {
                    consultaPoliza = mapper.Map<CreaPersonaResult>(poliza);
                    consultaPoliza.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return consultaPoliza;
        }
    }
}
