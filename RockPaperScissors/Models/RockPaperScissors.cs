namespace Game.Models
{
  public class RockPaperScissors
  {
    public string UserChoice { get; set; }
    public string ComputerChoice { get; set; }

    public RockPaperScissors(string userChoice)
    {
      UserChoice = userChoice;
    }
  }
}