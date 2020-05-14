namespace SixLetterWords {

  public class InputWord : Word {
    public InputWord(string value) : base(value)
    {
    }
    public static WordCombination operator +(InputWord obj1, InputWord obj2) {
      return new WordCombination(obj1,obj2);
    }
  }
}
