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

    [TestMethod]
    public void GetGameResult_ReturnsDrawForSameChoices_Draw()
    {
      string userChoice = "paper";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "paper";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "draw");
    }

    [TestMethod]
    public void GetGameResult_ReturnsWinForPaperVRock_Win()
    {
      string userChoice = "paper";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "rock";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "win");
    }

    [TestMethod]
    public void GetGameResult_ReturnsWinForRockVScissors_Win()
    {
      string userChoice = "rock";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "scissors";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "win");
    }

    [TestMethod]
    public void GetGameResult_ReturnsWinForScissorsVPaper_Win()
    {
      string userChoice = "scissors";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "paper";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "win");
    }

    [TestMethod]
    public void GetGameResult_ReturnsLossForPaperVScissors_Loss()
    {
      string userChoice = "paper";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "scissors";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "loss");
    }

    [TestMethod]
    public void GetGameResult_ReturnsLossForScissorsVRock_Loss()
    {
      string userChoice = "scissors";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "rock";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "loss");
    }

    [TestMethod]
    public void GetGameResult_ReturnsLossForRockVPaper_Loss()
    {
      string userChoice = "rock";
      RockPaperScissors round = new RockPaperScissors(userChoice);
      round.ComputerChoice = "paper";

      string result = round.GetGameResult();

      Assert.AreEqual(result, "loss");
    }
  }
}