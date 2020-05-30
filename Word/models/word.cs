using System.Collections.Generic;
using System;

namespace Word.Models

{
  public class RepeatCounter
  {
    public string Sentence { get; set; }

    public Dictionary<string, int> Dict = new Dictionary<string, int>();

    public RepeatCounter(string sentence)
    {
      Sentence = sentence;
    }
    public void WordCount()
    {
      string[] words = Sentence.ToLower().Split(" ");

      foreach (string word in words)
      {
        if(Dict.ContainsKey(word))
        {
        Dict[word] ++;
        }
        else
        {
          Dict.Add(word, 1);
        }
      }
    }
  }
}

