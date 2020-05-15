using System.Collections.Generic;
using System.Linq;
using SixLetterWords.WordCombinations;

namespace SixLetterWords
{
  class WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinder : IWordCombinationFinder {
    private readonly int _combinationLength;

    private readonly WordCombinationComparer _comparer = new WordCombinationComparer();

    public WordCombinationTupleWithExactResultingWordLenthAndAlsoInInputFinder(int combinationLength) {
      _combinationLength = combinationLength;
    }
    public IList<WordCombination> FindAllCombinations(IList<InputWord> inputWords) {
      var wordsWithDesiredLength = inputWords.Where(w => w.Length == _combinationLength).ToArray();
      var inputAsWordCombos = inputWords.Select(x => new WordCombination(x)).ToList();
      var seed = inputAsWordCombos.ToList(); // clone
      return CombineWords(inputAsWordCombos, seed) 
          .Where(w => wordsWithDesiredLength.Any(s=>s.Value==w.Value))
          .ToList();
    }

    private IList<WordCombination> CombineWords(IList<WordCombination> inputWords, List<WordCombination> combined) {
      //var alreadyFound = combined.Where(_ => _.Length == _combinationLength).ToList(); // alreadyFound
      var desiredWordsAfterCombination = inputWords.Where(_ => _.Length == _combinationLength).ToList(); 
      var newCombinations = combined.SelectMany(w1 => {
        return inputWords.Select(w2 => w1 + w2);
      }).ToList();
      combined.RemoveAll(_ => _.Length != _combinationLength);
      //combined.AddRange(alreadyFound);
      combined.AddRange(newCombinations);
      combined.RemoveAll(_ => _ == null);
      combined.RemoveAll(w => w.Length > _combinationLength);
      combined.RemoveAll(combination => combination.Parts.Count == 1); // original input word, not a combination
      combined.RemoveAll(x => !desiredWordsAfterCombination.Any(y => y.Value.StartsWith(x.Value)));
      combined = combined.Distinct(_comparer).ToList();
      if (combined.All(_ => _.Length == _combinationLength)) return combined;
      return CombineWords(inputWords, combined);
    }
  }

}