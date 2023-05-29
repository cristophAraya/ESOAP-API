using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Cl.Propal.Sincronizacion.Helpers.Producers
{
    public class RabbitProducer : IRabbitProducer
    {
        public void SendProductMessage<T>(T message)
        {
            //Here we specify the Rabbit MQ Server. we use rabbitmq docker image and use it
            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
            string queueName = "upload";
            var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queueName, exclusive: false);
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            //put the data on to the product queue
            channel.BasicPublish(exchange: "", routingKey: queueName, body: body);
        }
    }
}
