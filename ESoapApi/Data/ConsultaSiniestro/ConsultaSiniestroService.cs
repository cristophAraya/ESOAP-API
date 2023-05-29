using AutoMapper;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro;

namespace Cl.Sura.ESoapApi.Data.ConsultaSiniestro
{
    public class ConsultaSiniestroService : IConsultaSiniestroService
    {
        private ISettingsConfig settings;
        private IConsultaSiniestroRepository consultaSiniestroRepository;
        private IMapper mapper;
        public ConsultaSiniestroService(IConsultaSiniestroRepository eventoRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.consultaSiniestroRepository = eventoRepository;
            this.mapper = mapper;
        }
        public ConsultaSiniestroResult ConsultaSiniestro( long claimNo)
        {
            ConsultaSiniestroResult listaConsultaSiniestro = new ConsultaSiniestroResult();
            listaConsultaSiniestro.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var eventos = consultaSiniestroRepository.ConsultaSiniestro(claimNo);
                if (eventos != null)
                {
                    listaConsultaSiniestro = mapper.Map<ConsultaSiniestroResult>(eventos);
                    listaConsultaSiniestro.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaConsultaSiniestro;

        }
    }
}
