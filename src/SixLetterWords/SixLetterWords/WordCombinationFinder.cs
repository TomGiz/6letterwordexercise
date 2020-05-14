using System.Collections;
using System.Collections.Generic;

namespace SixLetterWords {
  class WordCombinationFinder : IWordCombinationFinder {
    public int CombinationLength { get; }

    public IList<InputWord> FindAllCombinations(IEnumerable< InputWord> inputWords) {
      return new List<InputWord>();
    }

    public WordCombinationFinder(int combinationLength) {
      CombinationLength = combinationLength;
    }

    

  }

  public interface IWordCombinationFinder {
    int CombinationLength { get; }

    IList<InputWord> FindAllCombinations(IEnumerable< InputWord> inputWords);
  }
}
