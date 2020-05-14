using Xunit;

namespace SixLetterWords.Tests
{
    public class InputWordsRepositoryTests
    {
      [Fact]
      public void Can_create() {
        Assert.NotNull(new InputWordsRepository());
      }
    }
}
