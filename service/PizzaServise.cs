
using bigPizzaServer.models.models;
using bigPizzaServer.Interface;
using FileService;
namespace bigPizzaServer.service;

public class PizzaService : IPizza
{
    public static List<Pizza> Pizzas { get; set; }
    public DateTime date { get; set; }
    static int nextId = 7;
    private IFile<Pizza> _file;
    public PizzaService(IFile<Pizza> file)
    {
        this._file = file;
        Pizzas=_file.Read("/file/pizzaDB.json");
    }
 //   {
        
        // Pizzas = new List<Pizza>
        // {
        //     new Pizza { Id = 1, Name = "Classic Italian", IsGluten = false ,Price=89},
        //     new Pizza { Id = 2, Name = "Veggie", IsGluten = true ,Price=58},
        //     new Pizza { Id = 3, Name = "Muzzarella", IsGluten = true ,Price=44},
        //     new Pizza { Id = 4, Name = "Gouda", IsGluten = false ,Price=87},
        //     new Pizza { Id = 5, Name = "cream", IsGluten = true ,Price=74},
        //     new Pizza { Id = 6, Name = "Angel", IsGluten = true ,Price=20}
        // };

  //  }

public List<Pizza> GetAll() => Pizzas;

public Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
//    public Pizza? Get(int id) {
//         return PizzaService.Pizzas.FirstOrDefault(p=>p.id==id);

//    }


public void Add(Pizza pizza)
{
    pizza.Id = nextId++;
    Pizzas.Add(pizza);
    ReadWrite rw = new ReadWrite();
    rw.Write();
    rw.Read();
}

public void Delete(int id)
{
    var pizza = Get(id);
    if (pizza is null)
        return;

    Pizzas.Remove(pizza);
}

public void Update(Pizza pizza)
{
    var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
    if (index == -1)
        return;

    Pizzas[index] = pizza;
    ReadWrite rw = new ReadWrite();
    rw.Write();
}
}
