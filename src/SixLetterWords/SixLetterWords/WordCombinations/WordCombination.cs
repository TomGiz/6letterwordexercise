using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords {
  public class WordCombination : Word {
    public List<Word> Parts { get; private set; }

    public WordCombination(params Word[] words) : base(string.Join<string>("", words.Select(_ => _.Value))) {
      Parts = words.ToList();
    }

    private WordCombination(WordCombination obj1, WordCombination obj2) : base(obj1.Value + obj2.Value) {
      Parts = new List<Word>();
      Parts.AddRange(obj1.Parts);
      Parts.AddRange(obj2.Parts);
    }

    public override string ToString() {
      return $"{string.Join<string>(" + ", Parts.Select(_ => _.Value))} = {Value}";
    }

    //public static WordCombination operator +(WordCombination obj1, InputWord obj2) {
    //  var result = new WordCombination(obj1, obj2);
    //  result.Parts = obj1.Parts;
    //  result.Parts.Add(obj2);
    //  return result;
    //}

    //public static WordCombination operator +(InputWord obj1, WordCombination obj2) {
    //  var result = new WordCombination(obj1, obj2);
    //  result.Parts = new List<Word>();
    //  result.Parts.Add(obj1);
    //  result.Parts.AddRange(obj2.Parts);
    //  return result;
    //}

    public static WordCombination operator +(WordCombination obj1, WordCombination obj2) {
      return new WordCombination(obj1, obj2);
    }

  }
}