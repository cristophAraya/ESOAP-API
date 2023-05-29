
using Cl.Sura.ESoapApi.Models.Entities.Confirmar;
using Cl.Sura.ESoapApi.Models.Request.Confirmar;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.Confirmar
{
    public class ConfirmarRepository : IConfirmarRepository
    {
        public ConfirmarModel Confirmar(ConfirmarRequest listaConfirmarRequest)
        {
            ConfirmarModel listaConfirmarModel = null;
            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/insis-claim-cst/claim/requests-confirmation");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(listaConfirmarRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaConfirmarModel = JsonConvert.DeserializeObject<ConfirmarModel>(response.Content);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaConfirmarModel;
        }
    }
}
