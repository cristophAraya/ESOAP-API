using AutoMapper;
using Cl.Propal.Sincronizacion.Helpers.Producers;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Result.ConsultaPoliza;

namespace Cl.Sura.ESoapApi.Data.Poliza
{
    public class PolizaService : IPolizaService
    {
        private ISettingsConfig settings;
        private IPolizaRepository polizaRepository;
        private IMapper mapper;
        public PolizaService(IPolizaRepository polizaRepository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.polizaRepository = polizaRepository;
            this.mapper = mapper;
        }

        public ConsultaPolizaResult ConsultaPoliza(string numeroPoliza)
        {
            ConsultaPolizaResult consultaPoliza = new ConsultaPolizaResult();
            //consultaPoliza.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var poliza = polizaRepository.ConsultaPoliza(numeroPoliza);
                if(poliza != null)
                {
                    consultaPoliza = mapper.Map<ConsultaPolizaResult>(poliza);
                    consultaPoliza.StatusCode = StatusCodes.Status200OK;
                }
            }
            catch(TechnicalExcepction ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
            return consultaPoliza;
        }
    }
}
