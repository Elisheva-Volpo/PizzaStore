using bigPizzaServer.models.models;

namespace bigPizzaServer.Interface
{
    public interface IOrder
    {
        DateTime date { get; set; }

        List<Order> GetAll();
        Order? Get(string id);
        void Post(Order order);
    }
}
