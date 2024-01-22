
using bigPizzaServer.models.models;
using bigPizzaServer.Interface;

namespace bigPizzaServer.service
{
    public class OrderService: IOrder
    {
        public List<Order> Orders { get; }
        public DateTime date { get; set; }

        public OrderService()
        {
            Orders = new List<Order>
            {
                new Order { CustomerId = "Shlomo", TotalAmount=1},
                new Order { CustomerId = "Shifra", TotalAmount=10}
            };
        }

        public List<Order> GetAll() => Orders;
        public Order? Get(string id) => Orders.FirstOrDefault(p => p.CustomerId.Equals(id));
        public void Post(Order order)
        {
            Orders.Add(order);
        }


    }
}
