namespace SixLetterWords
{
  public class WordCombination : Word {
    public InputWord Part1 { get; }
    public InputWord Part2 { get; }

    public WordCombination(InputWord part1, InputWord part2) : base(part1?.Value + part2?.Value) {
      Part1 = part1;
      Part2 = part2;
    }

    public override string ToString() {
      return $"{Part1} + {Part2} = {Value}";
    }
  }
}