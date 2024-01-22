using bigPizzaServer.models.models;
using bigPizzaServer.Interface;

namespace bigPizzaServer.service

{
    public class WorkerService:IWorker
    {
        public List<Worker> Workers { get; }
        public DateTime date { get; set; }

        static int nextId = 3;
        public WorkerService()
        {
            Workers = new List<Worker>
        {
            new Worker { Id = 1, Name = "Classic Italian"},
            new Worker { Id = 2, Name = "Veggie" }
        };
        }

        public List<Worker> GetAll() => Workers;

        public Worker? Get(int id) => Workers.FirstOrDefault(p => p.Id == id);
    }
}
