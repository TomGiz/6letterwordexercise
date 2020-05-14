using System.Linq;
using NSubstitute;
using SixLetterWords.IO;
using Xunit;

namespace SixLetterWords.Tests {
  public class DistinctInputWordsRepositoryTests {

    [Fact]
    public void Can_create() {
      Assert.NotNull(new DistinctInputWordsRepository(null));
    }

    [Fact]
    public void Can_read_all_distinct_words() {
      var wordsProvider = Substitute.For<IInputWordsRepository>();
      var returnThis = new[] {"abc", "def", "abc", "ghi"}.Select(x=>new InputWord(x)).ToArray();
      wordsProvider.GetAll().Returns(returnThis);
      var sut = new DistinctInputWordsRepository(wordsProvider);
      Assert.Equal(3, sut.GetAll().Length);
    }

    [Fact]
    public void Can_read_all_distinct_words_from_file() {
      var sut = new DistinctInputWordsRepository(
        new InputWordsFromTxtFileRepository(
          new InputWordsFromTxtFileConfiguration("input.txt")));

      var words = sut.GetAll();

      Assert.Equal(1421, words.Length);
    }
  }
}
