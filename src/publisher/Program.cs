using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { Uri = new Uri("amqp://guest:guest@localhost:5672") };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "demo-queue", durable: true, exclusive: false, autoDelete: false, arguments: null);

                var message = new { Name = "Producer", Message = "Hellow from RabbitMQ" };
                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                channel.BasicPublish(exchange: "", routingKey: "demo-queue", basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
        }
    }
}
