using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords {
  class WordCombinationWithExactResultingWordLengthAndAlsoInInputFinder : WordCombinationWithExactResultingWordLengthFinder {

    public IList<WordCombination> FindAllCombinations(IList< InputWord> inputWords) {
      var wordsWithDesiredLength = inputWords.Where(w => w.Length == this.CombinationLength).ToArray();
      return base
        .FindAllCombinations(inputWords)
        .Where(w => wordsWithDesiredLength.Any(s=>s.Value==w.Value))
        .ToList();
    }

    public WordCombinationWithExactResultingWordLengthAndAlsoInInputFinder(int combinationLength)
    : base (combinationLength) {
    }
  }

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

  class WordCombinationFinder : IWordCombinationFinder {

    public IList<WordCombination> FindAllCombinations(IList< InputWord> inputWords) {
      var result = new List<WordCombination>();
      for (int i = 0; i < inputWords.Count(); i++) {
        for (int j = 0; j < inputWords.Count(); j++) {
          if (i == j) continue;
          result.Add(new WordCombination( inputWords[i],inputWords[j]));
        }
      }

      return result;
    }
  }

  public interface IWordCombinationFinder {
    IList<WordCombination> FindAllCombinations(IList< InputWord> inputWords);
  }
}
