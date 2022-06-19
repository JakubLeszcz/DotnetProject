namespace WebApplication2.Models;

public class Group
{
    public int ID { get; set; }
    public string Name { get; set; }
    
    public IList<Player>? Players { get; set; }

}