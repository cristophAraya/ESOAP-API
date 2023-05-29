using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Entities.RegistroCalculo;
using Cl.Sura.ESoapApi.Models.Request.RegistroCalculo;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.RegistroCalculo
{
    public class RegistroCalculoRepository : IRegistroCalculoRepository
    {
        public RegistroCalculoModel RegistroCalculo(RegistroCalculoRequest registroCalculoRequest)
        { 
            //REGISTRAR CALCULO => 124
            RegistroCalculoModel listaRegistroCalculoModel = null;

            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/calculation-indemnity");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(registroCalculoRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaRegistroCalculoModel = JsonConvert.DeserializeObject<RegistroCalculoModel>(response.Content);
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
            return listaRegistroCalculoModel;
        }
    }
}
