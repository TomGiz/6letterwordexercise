using System;
using System.Linq;
using SixLetterWords.IO;

namespace SixLetterWords {
  class Program {
    static void Main(string[] args) {

      var combinationLength = 6;
      var inputTxt = "input.txt";

      var reader = new DistinctInputWordsRepository(
        new IO.InputWordsFromTxtFileRepository(
          new InputWordsFromTxtFileConfiguration(inputTxt)));
      var inputWords = reader.GetAll();

      var combiner = new WordCombinationWithExactResultingWordLengthAndAlsoInInputFinder(combinationLength);
      var result = combiner.FindAllCombinations(inputWords.ToList());

      foreach (var word in result)
      {
        Console.WriteLine(word);
      }

      Console.WriteLine();
      Console.WriteLine($"Found {result.Count} unique word combinations of length {combinationLength}");

      Console.ReadKey();
    }
  }
}
