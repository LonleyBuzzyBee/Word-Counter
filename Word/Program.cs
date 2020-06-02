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
      string inputSentence = Console.ReadLine();
      Console.WriteLine("input a word in the sentence to see how many times it's repeated");
      string searchWord = Console.ReadLine();

   
        RepeatCounter userSentence = new RepeatCounter(inputSentence,searchWord);

        if(string.IsNullOrEmpty(inputSentence)||string.IsNullOrEmpty(searchWord))
        {
          Console.WriteLine("error empty input");
        }
        else
        {

        userSentence.FilterInput();
        userSentence.WordCount();
     
        if(userSentence.FilterInput() == "error")
        {
          Console.WriteLine("an input contains a number");
        }
        else if(userSentence.GetWordCount() == "not here")
        {
          Console.WriteLine("sentence does not contain search word");
        }
        else
        {

        Console.WriteLine("This is how many times the word is repeated");
        Console.WriteLine($"{searchWord} : {userSentence.GetWordCount()}");
        }
        
      } 
    }
  }
}