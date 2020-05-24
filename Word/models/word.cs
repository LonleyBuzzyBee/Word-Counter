namespace Word.Models
{
  public class RepeatCounter
  {
    public string Sentence { get; set; }
    public RepeatCounter(string sentence)
    {
      Sentence = sentence;
    }
  }
}