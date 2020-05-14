using Xunit;

namespace SixLetterWords.Tests {
  public class InputWordTests {

    [Fact]
    public void Can_create_and_read_back_properties() {
      var inputWord = new InputWord("hello");
      Assert.NotNull(inputWord);
      Assert.Equal("hello",inputWord.Value );
      Assert.Equal(5,inputWord.Length );
    }

    [Theory]
    [InlineData("abc", "abc", true)]
    [InlineData("", null, false)]
    public void Can_compare_with_structural_equality(string v1, string v2, bool expected) {
      var w1 = new InputWord(v1);
      var w2 = new InputWord(v2);
      Assert.Equal(expected, w1.Equals(w2));
      //Assert.Equal(expected, w1==w2);
    }
  }
}
