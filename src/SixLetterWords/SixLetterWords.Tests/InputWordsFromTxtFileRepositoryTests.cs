using Xunit;

namespace SixLetterWords.Tests
{
    public class InputWordsFromTxtFileRepositoryTests
    {
      [Fact]
      public void Can_create() {
        Assert.NotNull(new InputWordsFromTxtFileRepository(null));
      }

      [Fact]
      public void Can_read_all_words() {
        var sut =  new InputWordsFromTxtFileRepository(new InputWordsFromTxtFileConfiguration("input.txt"));

        var words = sut.GetAll();

        Assert.Equal(4202, words.Length);
      }
    }
}
