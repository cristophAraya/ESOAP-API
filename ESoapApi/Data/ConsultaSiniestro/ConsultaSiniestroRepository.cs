
using Cl.Sura.ESoapApi.Models.Entities.ConsultaSiniestro;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Result.ConsultaSiniestro;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.ConsultaSiniestro
{
    public class ConsultaSiniestroRepository : IConsultaSiniestroRepository
    {
        public ConsultaSiniestroModel ConsultaSiniestro(long claimNo)
        {
            ConsultaSiniestroModel listaConsultaSiniestroModel = null;
            try
            {
                var options = new RestClientOptions("https://apim-segurossura-preprd.azure-api.net/")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest($"/insis-claim-cst/claim/erm?claimNo={claimNo}", Method.Get);
                var body = @"";
                request.AddParameter("text/plain", body, ParameterType.RequestBody);
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var response = client.Execute(request);       

                if (response.IsSuccessStatusCode)
                {
                    listaConsultaSiniestroModel = JsonConvert.DeserializeObject<ConsultaSiniestroModel>(response.Content);
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
            return listaConsultaSiniestroModel;
        }
    }
}
