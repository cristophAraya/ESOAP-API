using Cl.Sura.ESoapApi.Models.Request.RegistroDenuncio;
using Cl.Sura.ESoapApi.Models.Entities.RegistroDenuncio;
using Newtonsoft.Json;
using RestSharp;
using Cl.Sura.ESoapApi.Models.Entities.Error;

namespace Cl.Sura.ESoapApi.Data.RegistroDenuncio
{
    public class RegistroDenuncioRepository : IRegistroDenuncioRepository
    {
        public RegistroDenuncioModel RegistroDenuncio(RegistroDenunioRequest registroDenunioRequest)
        {

            RegistroDenuncioModel registroDenuncio = new RegistroDenuncioModel();

            try
            {
                //110
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/fnol/");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(registroDenunioRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);

                if (response.IsSuccessStatusCode)
                {
                    registroDenuncio = JsonConvert.DeserializeObject<RegistroDenuncioModel>(response.Content);
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
