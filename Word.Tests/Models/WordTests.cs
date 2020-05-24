using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word.Models;

namespace Word.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void RepeatWorddConstructor_CreatesInstance()
    {
      RepeatCounter newCounter = new RepeatCounter("");
      string sentence = newCounter.Sentence;

      Assert.AreEqual("", sentence);
    }
    [TestMethod]
    public void RepeatCounter_ReturnsIt()
    {
      RepeatCounter newCounter = new RepeatCounter("dog");
      newCounter.WordCount();
      int timesWordRepeat = newCounter.RepeatTimes;
      Assert.AreEqual(5, timesWordRepeat);
    }
  }
}