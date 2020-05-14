namespace SixLetterWords {

  public class InputWordsFromTxtFileConfiguration {
    public string FilePath  => "input.txt";
  }

  class InputWordsFromTxtFileRepository : IInputWordsRepository{
    private readonly InputWordsFromTxtFileConfiguration _config;

    public InputWordsFromTxtFileRepository(InputWordsFromTxtFileConfiguration config) {
      _config = config;
    }
    public string[] GetAll() {
      var words = System.IO.File.ReadAllLines(_config.FilePath);
      return words;
    }
  }

  public interface IInputWordsRepository {
    string[] GetAll();
  }
}
