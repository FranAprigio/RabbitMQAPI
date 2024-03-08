namespace RabbitMQProductAPI.RabbitMQ;

public interface IRabbitMQProduct
{
    public void SendProductMessage<T>(T message);
}