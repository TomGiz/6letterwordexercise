using System.Linq;
using Xunit;

namespace SixLetterWords.Tests {
  public class WordCombinationFinderTests {

    [Fact]
    public void Can_create() {
      var sut = new WordCombinationFinder();
      Assert.NotNull(sut);
    }

    
    [Fact]
    public void Can_combine() {
      var sut = new WordCombinationFinder();
      var words = new [] {"fo", "obar", "sun", "shine"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(12, result.Count);
      Assert.Contains(result, w => w.Value == "foobar");
      Assert.Contains(result, w => w.Value == "obarfo");
      Assert.Contains(result, w => w.Value == "sunshine");
      Assert.Contains(result, w => w.Value == "sunfo");
    }
  }
}
