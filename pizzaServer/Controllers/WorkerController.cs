using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bigPizzaServer.models.models;
using bigPizzaServer.service;
using bigPizzaServer.Interface;

namespace bigPizzaServer.pizzaServer.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {

        private IWorker iw;
        public WorkerController(IWorker iw)
        {
            this.iw = iw;
            iw.date = DateTime.Now;

        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Worker> Get(int id)
        {
            var worker = iw.Get(id);

            if (worker == null)
                return NotFound();

            return worker;

        }
    }
}
