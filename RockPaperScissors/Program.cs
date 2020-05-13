using System;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      string userInput;
      bool gameFinished = false;
      string gameResult;

      while (!gameFinished)
      {
        Console.WriteLine("Make your choice! (Rock/Paper/Scissors/Quit)");
        userInput = Console.ReadLine().ToLower();

        if (userInput == "rock" || userInput == "paper" || userInput == "scissors")
        {
          RockPaperScissors round = new RockPaperScissors(userInput);

          switch (round.GetGameResult())
          {
            case "win":
              gameResult = "Congratulations, your " + round.UserChoice + " beat the computer's " + round.ComputerChoice + ".";
              break;
            case "loss":
              gameResult = "Sorry, your " + round.UserChoice + " lost to the computer's " + round.ComputerChoice + ".";
              break;
            case "draw":
              gameResult = "How about that, its a draw. You both chose " + round.UserChoice + ".";
              break;
            default:
              gameResult = "There was an error determining a win.";
              break;
          }
        }
        else if (userInput == "quit")
        {
          gameFinished = true;
          gameResult = "Thanks for playing, goodbye.";
        }
        else
        {
          gameResult = "Sorry, that was an invalid option.";
        }

        Console.WriteLine(gameResult);
      }
    }
  }
}