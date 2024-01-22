using bigPizzaServer.models.models;

namespace bigPizzaServer.Interface
{
    public interface IPizza
    {
        static List<Pizza> Pizzas { get; set;}
        DateTime date { get; set; }

        List<Pizza> GetAll();

        Pizza? Get(int id);

        void Add(Pizza pizza);

        public void Delete(int id);

        public void Update(Pizza pizza);
    }
}
