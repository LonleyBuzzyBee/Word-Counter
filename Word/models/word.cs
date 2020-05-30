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
      WordCount();
    }

    public int GetWordCount(string word) {

      // check dictionary to see if key exists

      // if key exists ruturn value else return 0
      return 0;
    }

    private void WordCount()
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

