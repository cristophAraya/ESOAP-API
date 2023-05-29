using AutoMapper;
using Cl.Sura.ESoapApi.Helpers.Base;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Request.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Result.RegistroDenuncio;

namespace Cl.Sura.ESoapApi.Data.RegistroDenuncio
{
    public class RegistroDenuncioService : IRegistroDenuncioService
    {
        private ISettingsConfig settings;
        private IRegistroDenuncioRepository registroDenuncioRespository;
        private IMapper mapper;
        public RegistroDenuncioService(IRegistroDenuncioRepository registroDenuncioRespository, IMapper mapper, ISettingsConfig settings)
        {
            this.settings = settings;
            this.registroDenuncioRespository = registroDenuncioRespository;
            this.mapper = mapper;
        }
        public RegistroDenuncioResult RegistroDenuncio(RegistroDenunioRequest registroDenunioRequest)
        {
            RegistroDenuncioResult registro = new RegistroDenuncioResult();
            registro.StatusCode = StatusCodes.Status204NoContent;
            try
            {
                var poliza = registroDenuncioRespository.RegistroDenuncio(registroDenunioRequest);
                if (poliza != null)
                {
                    registro = mapper.Map<RegistroDenuncioResult>(poliza);
                    registro.StatusCode = StatusCodes.Status200OK;
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
            return registro;
        }
    }
}
