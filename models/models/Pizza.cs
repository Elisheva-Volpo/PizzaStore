

namespace bigPizzaServer.models.models;


public class Pizza
{
    public int Id { get; set; }
    public int Price { get; set; }
    public bool IsGluten { get; set; }
    public string Name { get; set; }

    // public readonly string Summaries { get; set; }

    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };

    public Pizza() => this.Name = "";
    public Pizza(int Id,string name,int price)
    {
        this.Id=Id;
        this.Name=name;
        this.Price=price;
    }

}