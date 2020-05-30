using System.Collections.Generic;
using System;
using Word.Models;

namespace Word
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("input a sentence");

      string input = Console.ReadLine();

     
      RepeatCounter userSentence = new RepeatCounter(input);
    

      Console.WriteLine("This is how many times each word is repeated");

     foreach(var word in userSentence.GetWords())
     {
       Console.WriteLine($"{word} : {userSentence.GetWordCount(word)}" );
     }
    }
  }
}