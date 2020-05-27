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
    public void RepeatCounter_ReturnsInt()
    {
      RepeatCounter newCounter = new RepeatCounter("dog");
      newCounter.WordCount();
      int timesWordRepeat = newCounter.RepeatTimes;
      Assert.AreEqual(1, timesWordRepeat);
    }
    [TestMethod]
    public void RepeatCounter_ReturnsnumberOfTimesWordIsRepeated()
    {
      RepeatCounter newCounter = new RepeatCounter("dog black");
      newCounter.WordCount();
      int timesWordRepeat = newCounter.RepeatTimes;
      Assert.AreEqual(1, timesWordRepeat);
    }
  }
}