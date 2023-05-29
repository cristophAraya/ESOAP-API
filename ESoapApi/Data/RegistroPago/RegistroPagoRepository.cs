using Cl.Sura.ESoapApi.Models.Entities.Error;
using Cl.Sura.ESoapApi.Models.Entities.RegistroPago;
using Cl.Sura.ESoapApi.Models.Request.RegistroPago;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.RegistroPago
{
    public class RegistroPagoRepository : IRegistroPagoRepository
    {
        public RegistroPagoModel RegistroPago(RegistroPagoRequest listaRegistroPagoRequest)
        {
            RegistroPagoModel listaRegistroPagoModel = null;
            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/payment");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(listaRegistroPagoRequest);
                request.AddStringBody(body, DataFormat.Json);

                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaRegistroPagoModel = JsonConvert.DeserializeObject<RegistroPagoModel>(response.Content);
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
            return listaRegistroPagoModel;
        }
    }
}
