﻿namespace SixLetterWords
{
  public class InputWordsFromTxtFileConfiguration : IInputWordsFromTxtFileConfiguration {
    public InputWordsFromTxtFileConfiguration(string filepath) {
      FilePath = filepath;
    }

    public string FilePath { get; }
  }
}