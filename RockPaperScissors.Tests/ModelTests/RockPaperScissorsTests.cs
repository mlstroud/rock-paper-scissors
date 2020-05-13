using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Game.Models;

namespace Game.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void Constructor_StoresUserChoice_UserChoice()
    {
      string userChoice = "paper";
      RockPaperScissors round = new RockPaperScissors(userChoice);

      string result = round.UserChoice;

      Assert.AreEqual(result, userChoice);
    }

    [TestMethod]
    public void Constructor_ChoosesRandomChoiceForComputer_ComputerChoice()
    {
      List<string> computerChoices = new List<string> { "paper", "rock", "scissors" };
      RockPaperScissors round = new RockPaperScissors("test");

      string computerChoice = round.ComputerChoice;
      bool result = computerChoices.Contains(computerChoice);

      Assert.AreEqual(true, result);
    }
  }
}