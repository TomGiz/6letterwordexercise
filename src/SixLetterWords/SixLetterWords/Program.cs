using System;
using System.Linq;
using SixLetterWords.IO;

namespace SixLetterWords {
  class Program {
    static void Main(string[] args) {
      var reader = new IO.InputWordsFromTxtFileRepository(new InputWordsFromTxtFileConfiguration("input.txt"));
      var inputWords = reader.GetAll();

      var combiner = new WordCombinationWithExactResultingWordLengthAndAlsoInInputFinder(6);
      var result = combiner.FindAllCombinations(inputWords.ToList());

      foreach (var word in result)
      {
        Console.WriteLine(word);
      }

      Console.ReadKey();
    }
  }
}
