using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
    public void RepeatCounter_AddsValueToDict()
    {
      RepeatCounter newSentence = new RepeatCounter("dog dog");

      newSentence.WordCount();

     
      var timesWordRepeat = newSentence.Dict["dog"];

      Assert.AreEqual(2,timesWordRepeat);
    }
    [TestMethod]
    public void RepeatCounter_ChecksForRepeatWords()
    {
      RepeatCounter newSentence = new RepeatCounter("hey going hows it going");

      newSentence.WordCount();

      var word1  = newSentence.Dict["hey"];
      var word2  = newSentence.Dict["going"];
      var word3  = newSentence.Dict["hows"];
      var word4  = newSentence.Dict["it"];


      Assert.AreEqual(1,word1);
      Assert.AreEqual(2,word2);
      Assert.AreEqual(1,word3);
      Assert.AreEqual(1,word4);
    }
    [TestMethod]
    public void RepeatCounterRemovesSpecialChar_()
    {
      RepeatCounter newSentence = new RepeatCounter("hey how's it going");

      newSentence.WordCount();

      var word1  = newSentence.Dict["hey"];
      var word2  = newSentence.Dict["going"];
      var word3  = newSentence.Dict["hows"];
      var word4  = newSentence.Dict["it"];


      Assert.AreEqual(1,word1);
      Assert.AreEqual(2,word2);
      Assert.AreEqual(1,word3);
      Assert.AreEqual(1,word4);
    }
  }
}
//checks if is not in dictionary than its equal to zero