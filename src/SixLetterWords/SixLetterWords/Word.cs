using System;

namespace SixLetterWords
{
  public class Word : IEquatable<Word> {

    public string Value { get; }

    public Word(string value) {
      Value = value;
    }

    public Word(Word other) {
      Value = other.Value;
    }
    
    public int Length => Value.Length;

    public override string ToString() {
      return Value;
    }

    public override bool Equals(object obj) {
      if (!(obj is Word otherWord)) return false;
      return Value == otherWord.Value;
    }

    public override int GetHashCode()
    {
      return (Value != null ? Value.GetHashCode() : 0);
    }

    public bool Equals(Word other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return string.Equals(Value, other.Value);
    }

    public static bool operator ==(Word obj1, Word obj2) {
      if (ReferenceEquals(obj1, obj2))
      {
        return true;
      }

      if (ReferenceEquals(obj1, null))
      {
        return false;
      }
      if (ReferenceEquals(obj2, null))
      {
        return false;
      }

      return obj1.Equals(obj2);
    }

    public static bool operator !=(Word obj1, Word obj2) {
      return !(obj1 == obj2);
    }

  }
}