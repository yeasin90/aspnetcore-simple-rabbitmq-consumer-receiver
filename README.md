Very basic RabbitMQ publisher/subscriber using .NET 5 Console application. One console application will publish a message to RabbitMq. Another console app will listen the queue and output the message in console window

Dependencies : 
- Install .NET 5 on a VS2019 machine : https://www.claudiobernasconi.ch/2020/10/21/install-and-use-csharp-9-in-visual-studio-2019/
- Setup RabbitMQ with Docker in Windows 10 machine : https://medium.com/dev-genius/rabbitmq-with-docker-on-windows-in-30-minutes-172e88bb0808
(RabbitMQ is a server which itself needs to be running. That's why we need Docker where RabbitMQ server will be running. Similar for Redis or other required hosted server)
- Tutorial on consumer/receiver app : https://www.youtube.com/watch?v=w84uFSwulBI
