using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Word.Models

{
  public class RepeatCounter
  {
    public string Sentence { get; set; }

    private Dictionary<string, int> WordDict = new Dictionary<string, int>();

    public RepeatCounter(string sentence)
    {
      
      Sentence = sentence.ToLower(); 
      WordCount();
    }

    public int GetWordCount(string word) {

      // check dictionary to see if key exists
      if (WordDict.ContainsKey(word.ToLower()))
      {
        return WordDict[word];
      }

      // if key exists ruturn value else return 0
      return 0;
    }
    public List<string> GetWords()
    {
      List<string> Words = new List<string>();
      foreach(var key in WordDict.Keys)
      {
        Words.Add(key);
      }
      return Words;
    } 

    private void WordCount()
    {
      Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"]))", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
    
      // strip special chars here
      string[] words = Sentence.Split(" ");

      foreach (string word in words)
      {
      
        string formatedWord = r.Replace(word, String.Empty).Replace(" ", "");

        if(WordDict.ContainsKey(formatedWord))
        {
          WordDict[formatedWord] ++;
        }
        else
        {
          WordDict.Add(formatedWord, 1);
        }
      }
    }
  }
}
// Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
//     return r.Replace(input, String.Empty);
