using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords
{
  class WordCombinationPairWithExactResultingWordLengthAndAlsoInInputFinder : WordCombinationPairWithExactResultingWordLengthFinder {

    public IList<WordCombination> FindAllCombinations(IList< InputWord> inputWords) {
      var wordsWithDesiredLength = inputWords.Where(w => w.Length == this.CombinationLength).ToArray();
      return base
        .FindAllCombinations(inputWords)
        .Where(w => wordsWithDesiredLength.Any(s=>s.Value==w.Value))
        .ToList();
    }

    public WordCombinationPairWithExactResultingWordLengthAndAlsoInInputFinder(int combinationLength)
      : base (combinationLength) {
    }
  }
}