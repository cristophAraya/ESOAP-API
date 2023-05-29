using AutoMapper;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Request.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Result.RegistroReclamante;

namespace Cl.Sura.ESoapApi.Data.RegistroReclamante
{
    public class RegistroReclamanteService : IRegistroReclamanteService
    {
        private ISettingsConfig settings;
        private IRegistroReclamanteRepository registroDenuncioRespository;
        private IMapper mapper;
        public RegistroReclamanteService(IRegistroReclamanteRepository registroDenuncioRespository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.registroDenuncioRespository = registroDenuncioRespository;
            this.mapper = mapper;
        }
        public RegistroReclamanteResult RegistroReclamante(RegistroReclamanteRequest registroDenunioRequest)
        {
            RegistroReclamanteResult registro = new RegistroReclamanteResult();
            registro.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var poliza = registroDenuncioRespository.RegistroReclamante(registroDenunioRequest);
                if (poliza != null)
                {
                    registro = mapper.Map<RegistroReclamanteResult>(poliza);
                    registro.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return registro;
        }
    }
}
