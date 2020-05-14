using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords
{
  class WordCombinationWithExactResultingWordLengthFinder : WordCombinationFinder {
    public int CombinationLength { get; }

    public IList<WordCombination> FindAllCombinations(IList< InputWord> inputWords) {
      return base
        .FindAllCombinations(inputWords)
        .Where(w => w.Length == this.CombinationLength)
        .ToList();
    }

    public WordCombinationWithExactResultingWordLengthFinder(int combinationLength) {
      CombinationLength = combinationLength;
    }
  }
}