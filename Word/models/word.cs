using System.Collections.Generic;
using System;

namespace Word.Models

{
  public class RepeatCounter
  {
    public string Sentence { get; set; }

    
    public RepeatCounter(string sentence)
    {
      Sentence = sentence;
    }
    public void WordCount()
    {
      string[] words = Sentence.ToLower().Split(" ");

      for(int index = 0; index< words.Length; index++)
      {
        int repeatCount = 1;

        for(int j = index + 1; j < words.Length; j++)
        {
          if(words[index].Equals(words[j]))
          {
            repeatCount++;
           
          }

        words[index].ToString();
        }
        
      }







    }

  }
}