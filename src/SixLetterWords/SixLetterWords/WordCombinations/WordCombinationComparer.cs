using System.Collections.Generic;

namespace SixLetterWords.WordCombinations
{
  class WordCombinationComparer : IEqualityComparer<WordCombination> {
    public bool Equals(WordCombination x, WordCombination y) {
      if (x.Value != y.Value) return false;
      if (x.Parts.Count != y.Parts.Count) return false;
      for (var i = 0; i < x.Parts.Count; i++) {
        if (x.Parts[i] != y.Parts[i]) return false;
      }
      return true;
    }

    public int GetHashCode(WordCombination obj) {
      unchecked // Overflow is fine, just wrap
      {
        int hash = 17;
        // Suitable nullity checks etc, of course :)
        foreach (var part in obj.Parts) {
          hash = hash * 23 + part.GetHashCode();
        }
        return hash;
      }
    }
  }
}