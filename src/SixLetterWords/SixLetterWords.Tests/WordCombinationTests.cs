using Xunit;

namespace SixLetterWords.Tests {
  public class WordCombinationTests {
    [Fact]
    public void Can_combine_two_inputwords_with_correct_Value() {
      var combination = new WordCombination(new InputWord("abc"), new InputWord("def") );
      Assert.Equal("abcdef", combination.Value);
    }
    [Fact]
    public void Can_combine_two_inputwords_with_correct_ToString() {
      var combination = new WordCombination(new InputWord("abc"), new InputWord("def") );
      Assert.Equal("abc + def = abcdef", combination.ToString());
    }
  }
}
