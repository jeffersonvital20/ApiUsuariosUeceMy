using ApiUsuariosUeceMy.Services.Interface;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Services.Results;

namespace ApiUsuariosUeceMy.Services;

public class RabbitServices : IRabbitServices
{
    private readonly IUsuarioRepository _usuarioRepository;
    public RabbitServices(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }
    public bool ReceveMensagem()
    {
        var factory = new ConnectionFactory 
        {
            HostName = "localhost" ,
            UserName = "admin" ,
            Password = "123456" ,
        };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "FilaPagamento",
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);

        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (model, ea) =>
        {
            Thread.Sleep(1);
            var body = ea.Body.ToArray();
            var json = Encoding.UTF8.GetString(body);
            var result = JsonSerializer.Deserialize<Payment>(json);            
            _usuarioRepository.AtualizaCurso(result.IdUsuario,result.IdCurso);
            Thread.Sleep(1);
        };
        channel.BasicConsume(queue: "FilaPagamento",
                             autoAck: true,
                             consumer: consumer);
        return true;
    }
}
