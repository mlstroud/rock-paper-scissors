using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}