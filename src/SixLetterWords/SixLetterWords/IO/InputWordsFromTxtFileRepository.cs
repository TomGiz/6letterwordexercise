﻿using System.Linq;

namespace SixLetterWords.IO
{
  class InputWordsFromTxtFileRepository : IInputWordsRepository{
    private readonly InputWordsFromTxtFileConfiguration _config;

    public InputWordsFromTxtFileRepository(InputWordsFromTxtFileConfiguration config) {
      _config = config;
    }
    public InputWord[] GetAll() {
      var words = System.IO.File.ReadAllLines(_config.FilePath);
      return words.Select(s=>new InputWord(s)).ToArray();
    }
  }

  class DistinctInputWordsRepository : IInputWordsRepository {
    
    private readonly IInputWordsRepository _inner;

    public DistinctInputWordsRepository(IInputWordsRepository inner) {
      _inner = inner;
    }

    public InputWord[] GetAll() {
      return _inner.GetAll().Distinct().ToArray();
    }

  }
}