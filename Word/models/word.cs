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
    public int WordCount()
    {
      RepeatTimes = 0;
      Sentence = Sentence.ToUpper();
      return RepeatTimes;
    }

  }
}