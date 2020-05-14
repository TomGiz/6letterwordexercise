using System.Linq;
using Xunit;

namespace SixLetterWords.Tests {
  public class WordCombinationFinderTests {

    [Fact]
    public void Can_create_read_back_length() {
      var sut = new WordCombinationFinder(18);
      Assert.NotNull(sut);
      Assert.Equal(18, sut.CombinationLength);
    }

    [Fact]
    public void Can_combine() {
      var sut = new WordCombinationFinder(6);
      var words = new [] {"fo", "obar"};
      var result = sut.FindAllCombinations(words.Select(w => new InputWord(w)));
      Assert.NotNull(result);
      Assert.Equal(2, result.Count);
    }
  }
}
