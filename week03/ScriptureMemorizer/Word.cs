using System;

public class Word
// This class has the responsibility of storing all the words in a scripture verse or verses.
// It can also confirm if a word is hidden or not so as to completely hide all words.
// It also hides some words in the verse and display the verse with some word hidden with an underscore.
{
    private string[] _words; 
    private bool[] _IsHidden;

    public Word(string text)
    {
        _words = text.Split(new char[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        _IsHidden = new bool [_words.Length];

    }

    public void Hide()
    {
        List<int> indices = new List<int>();

        // Get the indices of available word to hide and end the method, if available words to hide is zero.
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_IsHidden[i])
            {
                indices.Add(i);
            }
        }
        if (indices.Count == 0) return;

        // Get the random number of words to hide.
        Random random = new Random();
        int numberToReplace = random.Next(1, 4);
        if (numberToReplace > indices.Count)
        {
            numberToReplace = indices.Count;
        }
        
        // Choose the random word to hide.
        for (int i = 0; i < numberToReplace; i++)
        {
            int randomIndex = random.Next(indices.Count);
            int wordIndex = indices[randomIndex];
            _IsHidden[wordIndex] = true;
            indices.Remove(randomIndex);
        }
    }
    
    public void Show()
    {
        // Replace chosen words with (_) and display the sentece with the hidden word.
        for (int i = 0; i < _words.Length; i++)
        {
            if (_IsHidden[i])
            {
                Console.Write(new string('_', _words[i].Length));
            }
            else
            {
                Console.Write(_words[i]);
            }
            if (i < _words.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    public bool IsHidden()
    {
        // Return false if the sentence is not hidden but true if the sentence is hidden.
        for (int i = 0; i < _IsHidden.Length; i++)
        {
            if (!_IsHidden[i]) return false;
        }
        return true;
    }
    
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words);
        return text;
    }
    
}