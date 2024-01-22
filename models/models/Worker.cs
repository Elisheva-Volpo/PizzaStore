

namespace bigPizzaServer.models.models;

public class Worker{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Tel { get; set; }

    public Worker(){
        this.Tel="";
        this.Name="";
    }

    public Worker(string tel,string name){
        this.Tel=tel;
        this.Name=name;
    }
}