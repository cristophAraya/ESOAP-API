using Cl.Sura.ESoapApi.Models.Entities.ConfirmarCalculo;
using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Request.ConfirmarCalculo;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.ConfirmarCalculo
{
    public class ConfirmarCalculoRepository : IConfirmarCalculoRepository
    {
        public ConfirmarCalculoModel ConfirmarCalculo(ConfirmarCalculoRequest confirmarCalculoRequest)
        {
            //CONFIRMAR CALCULO => 125
            ConfirmarCalculoModel listaConfirmarCalculoModel = null;

            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/calculation-confirmation");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(confirmarCalculoRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaConfirmarCalculoModel = JsonConvert.DeserializeObject<ConfirmarCalculoModel>(response.Content);
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                    throw new TechnicalExcepction(error.Message);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return listaConfirmarCalculoModel;
        }
    }
}
