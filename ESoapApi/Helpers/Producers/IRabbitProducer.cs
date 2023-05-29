namespace Cl.Propal.Sincronizacion.Helpers.Producers
{
    public interface IRabbitProducer
    {
        public void SendProductMessage<T>(T message);
    }
}
