using Microsoft.AspNetCore.Mvc;
using bigPizzaServer.models.models;
using bigPizzaServer.service;
using bigPizzaServer.Interface;


namespace bigPizzaServer.pizzaServer.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PizzaController : ControllerBase
{
    private IPizza ip;
    public PizzaController(IPizza ip)
    {
        this.ip = ip;
        ip.date= DateTime.Now;
    }

    [HttpGet]
    [Route("getAll")]
    public ActionResult<List<Pizza>> GetAll() =>
    ip.GetAll();

    [HttpGet]
    [Route("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = ip.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = ip.Get(id);
        if (existingPizza is null)
            return NotFound();

        ip.Update(pizza);

        return NoContent();
    }

    [HttpPost]
    [Route("{pizza}")]
    public IActionResult Create(Pizza pizza)
    {
        ip.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);

    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = ip.Get(id);

        if (pizza is null)
            return NotFound();

        ip.Delete(id);

        return NoContent();
    }

}