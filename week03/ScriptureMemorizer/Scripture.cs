using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
// It responsibilities is to manage the full scripture (reference + word), handle display and control hiding logic
{
    private Reference _reference;
    private List<Word> _word;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List <Word> visibleWords = _word.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // prevention of re-hiding the same word
        }
    }

    public string GetDisplayText()
    {
        string wordText = string.Join(" ", _word.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordText}";
    }

    public bool IscompletelyHidden()
    {
        return _word.All(w => w.IsHidden());
    }
}
