using bigPizzaServer.models.models;

namespace bigPizzaServer.Interface
{
    public interface IWorker
    {
        List<Worker> Workers { get; }
        DateTime date { get; set; }

        public List<Worker> GetAll();

        public Worker? Get(int id);
    }
}
