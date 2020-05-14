using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords {


  class WordCombinationWithExactResultingWordLengthFinder : WordCombinationFinder {
    public int CombinationLength { get; }

    public IList<InputWord> FindAllCombinations(IList< InputWord> inputWords) {
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

    public IList<InputWord> FindAllCombinations(IList< InputWord> inputWords) {
      var result = new List<InputWord>();
      for (int i = 0; i < inputWords.Count(); i++) {
        for (int j = 0; j < inputWords.Count(); j++) {
          if (i == j) continue;
          result.Add(inputWords[i] + inputWords[j]);
        }
      }

      return result;
    }
  }

  public interface IWordCombinationFinder {
    IList<InputWord> FindAllCombinations(IList< InputWord> inputWords);
  }
}
