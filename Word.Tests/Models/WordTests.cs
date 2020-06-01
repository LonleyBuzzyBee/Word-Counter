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

      newSentence.GetWordCount("dog");

     
      var timesWordRepeat = newSentence.GetWordCount("dog");

      Assert.AreEqual(2,timesWordRepeat);
    }
    [TestMethod]
    public void RepeatCounter_ChecksForRepeatWords()
    {
      RepeatCounter newSentence = new RepeatCounter("hey going hows it going");

      var word1  = newSentence.GetWordCount("hey");
      var word2  = newSentence.GetWordCount("going");
      var word3  = newSentence.GetWordCount("hows");
      var word4  = newSentence.GetWordCount("it");


      Assert.AreEqual(1,word1);
      Assert.AreEqual(2,word2);
      Assert.AreEqual(1,word3);
      Assert.AreEqual(1,word4);
    }
    [TestMethod]
    public void RepeatCounterRemovesSpecialChar_()
    {
      RepeatCounter newSentence = new RepeatCounter("hey how is it going!");

      var word1  = newSentence.GetWordCount("hey");
      var word2  = newSentence.GetWordCount("going");
      var word3  = newSentence.GetWordCount("how");
      var word4  = newSentence.GetWordCount("it");

      Assert.AreEqual(1,word1);
      Assert.AreEqual(1,word2);
      Assert.AreEqual(1,word3);
      Assert.AreEqual(1,word4);
    }
    [TestMethod]
    public void RepeatCounterConjoinsWordsWComma_()
    {
      RepeatCounter newSentence = new RepeatCounter("hey how's it going");

      var word1  = newSentence.GetWordCount("hey");
      var word2  = newSentence.GetWordCount("going");
      var word3  = newSentence.GetWordCount("hows");
      var word4  = newSentence.GetWordCount("it");

      Assert.AreEqual(1,word1);
      Assert.AreEqual(1,word2);
      Assert.AreEqual(1,word3);
      Assert.AreEqual(1,word4);
    }
    [TestMethod]
    public void RepeatCounterChecksIfWordIsInDictionaryIfNotThenWordIsZero_()
    {
      RepeatCounter newSentence = new RepeatCounter("hope you have a nice day");

      var word1  = newSentence.GetWordCount("hope");
      var word2  = newSentence.GetWordCount("cherry");

      Assert.AreEqual(1,word1);
      Assert.AreEqual(0,word2);
    }
    [TestMethod]
    public void RepeatCounterLowercasesInput_()
    {
      RepeatCounter newSentence = new RepeatCounter("HEY");

      var word  = newSentence.GetWordCount("hey");
    
      Assert.AreEqual(1,word);
  
    }
   
  }
}

