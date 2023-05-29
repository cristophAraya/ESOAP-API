using Cl.Sura.ESoapApi.Models.Request.RegistroReclamante;
using Cl.Sura.ESoapApi.Models.Entities.RegistroReclamante;
using Newtonsoft.Json;
using RestSharp;
using Cl.Sura.ESoapApi.Models.Entities.Error;

namespace Cl.Sura.ESoapApi.Data.RegistroReclamante
{
    public class RegistroReclamanteRepository : IRegistroReclamanteRepository
    {
        public RegistroReclamanteModel RegistroReclamante(RegistroReclamanteRequest registroDenunioRequest)
        {

            RegistroReclamanteModel registroDenuncio = new RegistroReclamanteModel();

            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/request-creation/");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(registroDenunioRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);

                if (response.IsSuccessStatusCode)
                {
                    registroDenuncio = JsonConvert.DeserializeObject<RegistroReclamanteModel>(response.Content);
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                    throw new TechnicalExcepction(error.Message);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return registroDenuncio;
        }
    }
}
