using System.Linq;
using Xunit;

namespace SixLetterWords.Tests {
  public class WordCombinationWithExactResultingWordLengthFinderTests {

    [Fact]
    public void Can_create_read_back_length() {
      var sut = new WordCombinationWithExactResultingWordLengthFinder(18);
      Assert.NotNull(sut);
      Assert.Equal(18, sut.CombinationLength);
    }

    [Fact]
    public void Can_combine() {
      var sut = new WordCombinationWithExactResultingWordLengthFinder(6);
      var words = new [] {"fo", "obar"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(2, result.Count);
      Assert.True(result.All(w => w.Length==6));
      Assert.Contains(result, w => w.Value == "foobar");
      Assert.Contains(result, w => w.Value == "obarfo");
    }
  }
}
