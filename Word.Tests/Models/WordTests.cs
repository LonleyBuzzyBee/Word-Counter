using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Word.Models;

namespace Word.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void RepeatWordConstructor_CreatesInstance()
    {
      RepeatCounter newCounter = new RepeatCounter("the dog walks","walks");
      string sentence = newCounter.Sentence;
      string searchWord = newCounter.SearchWord;

      Assert.AreEqual("the dog walks", sentence);
      Assert.AreEqual("walks", searchWord);
    }
    [TestMethod]
    public void RepeatWordConstructor_MakesInputsLoweCased()
    {
      RepeatCounter newCounter = new RepeatCounter("THE DOG WALKS","WALKS");
      string sentence = newCounter.Sentence;
      string searchWord = newCounter.SearchWord;

      Assert.AreEqual("the dog walks", sentence);
      Assert.AreEqual("walks", searchWord);
    }
    [TestMethod]
    public void FilterInput_ChecksForStrIntReturnsErrorIfSentenceContainsInt()
    {
      RepeatCounter newSentence = new RepeatCounter("dog d0g","dog");
     
      var isValidOrError = newSentence.FilterInput();

      Assert.AreEqual("error",isValidOrError);
    }
    [TestMethod]
    public void FilterInput_ChecksForStrIntReturnsErrorIfSearchWordContainsInt()
    {
      RepeatCounter newSentence = new RepeatCounter("dog dog","d0g");
     
      var isValidOrError = newSentence.FilterInput();

      Assert.AreEqual("error",isValidOrError);
    }
    public void FilterInput_ChecksForStrIntReturnsValidIfInputDoesntContainInt()
    {
      RepeatCounter newSentence = new RepeatCounter("dog dog","dog");
     
      var isValidOrError = newSentence.FilterInput();

      Assert.AreEqual("is valid",isValidOrError);
    }
    [TestMethod]
    public void GetWordCount_ChecksForHowManyTimesWordIsInDictIfMoreThanOnceIntGoesUp()
    {
      RepeatCounter newRepeat = new RepeatCounter("dog dog", "dog");

      newRepeat.WordCount();
      var count = newRepeat.WordDict[newRepeat.SearchWord];


      Assert.AreEqual(2,count);
    }
    [TestMethod]
    public void GetWordCount_ChecksIfSearchWordInDict()
    {
      RepeatCounter newRepeat = new RepeatCounter("dog ", "dog");

       newRepeat.WordCount();
      var count = newRepeat.WordDict[newRepeat.SearchWord];


      Assert.AreEqual(1,count);
    }
    [TestMethod]
    public void GetWordCount_ChecksIfSearchWordInDictCountGoesUpIfMoreThanOnce()
    {
      RepeatCounter newSentence = new RepeatCounter("dog dog dog dog", "dog");

      newSentence.WordCount();
      var checkForStr = newSentence.GetWordCount();

      Assert.AreEqual("4",checkForStr);
    }
    [TestMethod]
    public void GetWordCount_ChecksIfSearchWordInDictIfNotReturnNotHere()
    {
      RepeatCounter newSentence = new RepeatCounter("dog dog", "yolo");

     newSentence.WordCount();
      var checkForStr = newSentence.GetWordCount();

      Assert.AreEqual("not here",checkForStr);
    }
  }
}

