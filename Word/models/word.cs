namespace Word.Models
{
  public class RepeatCounter
  {
    public string Sentence { get; set; }
    public int RepeatTimes { get; set; }
    public RepeatCounter(string sentence)
    {
      Sentence = sentence;
    }
    public void WordCount()
    {
      RepeatTimes = 0;
      string[] words = Sentence.Split(" ");
      foreach(var word in words)
      {
        RepeatTimes +=1;
      }
    
      
    }

  }
}