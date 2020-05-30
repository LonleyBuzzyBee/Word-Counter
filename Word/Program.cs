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
    

      userSentence.WordCount();


      Console.WriteLine("This is how many times each word is repeated"
      );

     foreach(var key in userSentence.Dict.Keys)
     {
       Console.WriteLine($"{key} : {userSentence.Dict[key]}" );
     }
    }
  }
}