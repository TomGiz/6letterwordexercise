using System.Collections.Generic;

namespace SixLetterWords
{
  public interface IWordCombinationFinder {
    IList<WordCombination> FindAllCombinations(IList< InputWord> inputWords);
  }
}