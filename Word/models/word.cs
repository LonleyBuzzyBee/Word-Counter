using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Word.Models

{
  public class RepeatCounter
  {
    public string Sentence { get; set; }
    public string SearchWord { get; set; }

    public Dictionary<string, int> WordDict = new Dictionary<string, int>();

    public RepeatCounter(string sentence, string searchWord)
    {

      Sentence = sentence.ToLower();
      SearchWord = searchWord.ToLower();

    }
    public string FilterInput()
    {
      string[] filterNums = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
      

      foreach (string numStr in filterNums)
      {
        if (Sentence.Contains(numStr)||SearchWord.Contains(numStr))
        {
          return "error";
        }
      }
      return "is valid";
    }
    public string GetWordCount()
    {

      if (WordDict.ContainsKey(SearchWord))
      {
        return WordDict[SearchWord].ToString();
      }
      return "not here";
    }

    public void WordCount()
    {

      string[] words = Sentence.Split(" ");

      foreach (string word in words)
      {

        if (WordDict.ContainsKey(word))
        {
          WordDict[word]++;
        }

        else
        {
          WordDict.Add(word, 1);
        }
      }
    }

  }
}

