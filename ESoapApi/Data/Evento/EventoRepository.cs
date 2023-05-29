using Cl.Sura.ESoapApi.Models.Entities.ListaEvento;
using Cl.Sura.ESoapApi.Models.Request.ListaEvento;
using Newtonsoft.Json;
using RestSharp;

namespace Cl.Sura.ESoapApi.Data.Evento
{
    public class EventoRepository : IEventoRepository
    {
        public ListaEventoModel ListaEventos(ListaEventoRequest listaEventoRequest)
        {
            ListaEventoModel listaEventoModel = null;
            try
            {
                var client = new RestClient("https://apim-segurossura-preprd.azure-api.net/util/query/paginated-query");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Ocp-Apim-Subscription-Key", "4aa272fa843a426e83104f09c75d813e");
                var body = JsonConvert.SerializeObject(listaEventoRequest);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    listaEventoModel = JsonConvert.DeserializeObject<ListaEventoModel>(response.Content);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaEventoModel;
        }
    }
}
