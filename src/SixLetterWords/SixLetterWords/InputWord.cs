namespace SixLetterWords {
  class InputWord {

    public string Value { get; }

    public InputWord(string value) {
      Value = value;
    }
    
    public int Length => Value.Length;

    public override string ToString() {
      return Value;
    }

    public override bool Equals(object obj) {
      if (!(obj is InputWord otherWord)) return false;
      return Value == otherWord.Value;
    }

    public override int GetHashCode()
    {
      return (Value != null ? Value.GetHashCode() : 0);
    }
  }
}
