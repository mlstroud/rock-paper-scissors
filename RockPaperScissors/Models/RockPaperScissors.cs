using System;

namespace Game.Models
{
  public class RockPaperScissors
  {
    public string UserChoice { get; set; }
    public string ComputerChoice { get; set; }
    public static string[] _computerChoices = { "rock", "paper", "scissors" };

    public RockPaperScissors(string userChoice)
    {
      UserChoice = userChoice;
      Random rand = new Random();
      ComputerChoice = _computerChoices[rand.Next(_computerChoices.Length)];
    }

    public string GetGameResult()
    {
      string result = "";
      if (UserChoice == ComputerChoice)
      {
        result = "draw";
      }

      return result;
    }
  }
}