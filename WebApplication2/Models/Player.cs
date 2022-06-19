namespace WebApplication2.Models;

public class Player
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int GroupID { get; set; }
    public Group? Group { get; set; }
    public int SuccessfulBets { get; set; }
    public int AllAttempts { get; set; }
    public float Score { get; set; }

    
}