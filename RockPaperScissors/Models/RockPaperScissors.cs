using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class RockPaperScissors
  {
    public string UserChoice { get; set; }
    public string ComputerChoice { get; set; }
    public static string[] _computerChoices = { "rock", "paper", "scissors" };
    public static Dictionary<string, string> winList = new Dictionary<string, string>
    {
      { "rock", "scissors" },
      { "scissors", "paper" },
      { "paper", "rock" }
    };

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
      else if (winList.ContainsKey(UserChoice) && winList[UserChoice] == ComputerChoice)
      {
        result = "win";
      }
      else
      {
        result = "loss";
      }

      return result;
    }
  }
}