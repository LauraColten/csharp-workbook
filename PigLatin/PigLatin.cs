using System;

namespace PigLatin
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to be translated to Pig Latin: ");
      string word = Console.ReadLine();
      Console.WriteLine(Translate(word));
      Console.WriteLine("Now, enter a sentence to be translated to Pig Latin: ");
      string sentence = Console.ReadLine();
      string[] separateWords = sentence.Split(' ');
      for (int i = 0; i < separateWords.Length; i++)
      {
        separateWords[i] = Translate(separateWords[i].ToLower());
      }
      Console.WriteLine(String.Join(' ', separateWords));
    }

    static string Translate(string word)
    {

      int halfWordLength = word.Length / 2;
      Convert.ToInt32(halfWordLength);
      string firstHalf = word.Substring(0, halfWordLength);
      string lastHalf = word.Substring(halfWordLength);
      int firstLetterIndex = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
      if (firstLetterIndex == 0)
      {
        if (word[word.Length - 1] == 'a' || word[word.Length - 1] == 'e' || word[word.Length - 1] == 'i' || word[word.Length - 1] == 'o' || word[word.Length - 1] == 'u')
        {
          return (word + "yay");
        }
        else
        {
          return (word + "ay");
        }
      }
      else if (!(word.Contains("a") || word.Contains("e") || word.Contains("i") || word.Contains("o") || word.Contains("u")))
      {
        int findY = word.IndexOf("y");
        string beforeY = word.Substring(0, findY);
        string afterY = word.Substring(findY);
        string newWord = afterY + beforeY + "ay";
        return (newWord);
      }
      else
      {
        string beforeVowel = word.Substring(0, firstLetterIndex);
        string vowelAndAfter = word.Substring(firstLetterIndex);
        string translatedWord = vowelAndAfter + beforeVowel + "ay";
        return (translatedWord);
      }
    }
  }
}
