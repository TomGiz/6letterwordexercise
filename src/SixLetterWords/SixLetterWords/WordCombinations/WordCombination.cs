using System.Collections.Generic;
using System.Linq;

namespace SixLetterWords
{
  public class WordCombination : Word {
    private List<Word> Parts { get; }

    public WordCombination(params Word[] words) : base(string.Join<string>("", words.Select(_=>_.Value))) {
      Parts = words.ToList();
    }

    public override string ToString() {
      return $"{string.Join<string>(" + ", Parts.Select(_=>_.Value))} = {Value}";
    }
  }
}