using System.Linq;
using Xunit;

namespace SixLetterWords.Tests {
  public class WordCombinationWithExactResultingWordLengthAndAlsoInInputFinderTests {

    [Fact]
    public void Can_create_read_back_length() {
      var sut = new WordCombinationWithExactResultingWordLengthAndAlsoInInputFinder(18);
      Assert.NotNull(sut);
      Assert.Equal(18, sut.CombinationLength);
    }

    [Fact]
    public void Can_combine() {
      var sut = new WordCombinationWithExactResultingWordLengthAndAlsoInInputFinder(6);
      var words = new [] {"fo", "obar", "foobar", "rhu", "barb"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(1, result.Count);
      Assert.True(result.All(w => w.Length==6));
      Assert.Contains(result, w => w.Value == "foobar");
    }

  }
}
