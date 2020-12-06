Very basic RabbitMQ publisher/subscriber using .NET 5 Console application. One console application will publish a message to RabbitMq. Another console app will listen the queue and output the message in console window

Dependencies : 
- To run Docker in Windows 10 Home, you must have Windows 10 Home Build >= 18917
- Install Docker in Windows 10 Home (you will need to setup wsl2) : https://docs.docker.com/docker-for-windows/install-windows-home/?fbclid=IwAR3LWY5cZ3agrtom1fFhMxQSGTttImiaMRNDDei6UrNQwMK7BAsw6ZOAndU
- **SPECIAL NOTE : Docker Desktop on Windows 10 Home is only able to run Linux Containers. It means it will always run in Linux container, even if you see Switch to Linux containers.. from task bar icon. Why? see this : https://github.com/docker/for-win/issues/9701 . This means you always have to choose Linux as Docker setup from Visual Studio
- Install .NET 5 on a VS2019 machine : https://www.claudiobernasconi.ch/2020/10/21/install-and-use-csharp-9-in-visual-studio-2019/
- Setup RabbitMQ with Docker in Windows 10 machine : https://medium.com/dev-genius/rabbitmq-with-docker-on-windows-in-30-minutes-172e88bb0808
(RabbitMQ is a server which itself needs to be running. That's why we need Docker where RabbitMQ server will be running. Similar for Redis or other required hosted server)
- Tutorial on consumer/receiver app : https://www.youtube.com/watch?v=w84uFSwulBI
