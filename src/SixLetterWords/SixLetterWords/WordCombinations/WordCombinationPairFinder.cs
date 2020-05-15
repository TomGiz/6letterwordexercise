using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords {
  class WordCombinationPairFinder : IWordCombinationFinder {

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
}
