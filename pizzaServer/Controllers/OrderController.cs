using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bigPizzaServer.models.models;
using bigPizzaServer.service;
using bigPizzaServer.Interface;

namespace bigPizzaServer.pizzaServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrder io;

        public OrderController(IOrder o)
        {
            io = o;
            io.date = DateTime.Now;

        }

        [HttpGet]
        [Route("{name}")]
        public ActionResult<Worker> Get(string name)
        {
            var order = io.Get(name);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<List<Order>> GetAll()
        {
            return Ok(io.GetAll());
        }


        [HttpPost]
        [Route("{order}")]
        public ActionResult<string> Post(Order order)
        {
            //return Ok(orderManager.Transmit(order));
            io.Post(order);
            return Ok("ok");
        }
    }
}
