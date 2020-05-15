using System.Linq;
using Xunit;

namespace SixLetterWords.Tests {
  public class WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinderTests {
    [Fact]
    public void Can_combine6_simple() {
      var sut = new WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinder(6);
      var words = new [] {"fo", "obar", "foobar"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(1, result.Count);
      Assert.True(result.All(w => w.Length==6));
      Assert.Contains(result, w => w.Value == "foobar" && w.Parts.Contains( new InputWord("obar")));
    }

    
    [Fact]
    public void Can_combine6() {
      var sut = new WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinder(6);
      var words = new [] {"fo", "obar", "foobar", "o", "bar"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(2, result.Count);
      Assert.True(result.All(w => w.Length==6));
      Assert.Contains(result, w => w.Value == "foobar" && w.Parts.Contains( new InputWord("bar")));
      Assert.Contains(result, w => w.Value == "foobar" && w.Parts.Contains( new InputWord("obar")));
    }

    [Fact]
    public void Can_combine6_complex() {
      var sut = new WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinder(6);
      var words = new [] {"fo", "obar", "foobar", "rhu", "barb", "o", "b", "bar", "rhubarb"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(2, result.Count);
      Assert.True(result.All(w => w.Length==6));
      Assert.Contains(result, w => w.Value == "foobar" && w.Parts.Contains( new InputWord("bar")));
      Assert.Contains(result, w => w.Value == "foobar" && w.Parts.Contains( new InputWord("obar")));
    }

    [Fact]
    public void Can_combine7() {
      var sut = new WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinder(7);
      var words = new [] {"fo", "obar", "foobar", "rhu", "barb", "o", "b", "bar", "rhubarb"};
      var result = sut.FindAllCombinations(
        words.Select(w => new InputWord(w)).ToList());
      Assert.NotNull(result);
      Assert.Equal(2, result.Count);
      Assert.True(result.All(w => w.Length==7));
      Assert.Contains(result, w => w.Value == "rhubarb" && w.Parts.Contains( new InputWord("barb")));
      Assert.Contains(result, w => w.Value == "rhubarb" && w.Parts.Contains( new InputWord("bar")));
    }
  }
}
