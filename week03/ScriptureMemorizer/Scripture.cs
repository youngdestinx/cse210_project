
using System;

public class Scripture
// It responsibilities is to manage the full scripture (reference + word), handle display and control hiding logic
{
    private Reference _reference;
    private Word _word;

    public Scripture(Reference reference, Word word)
    {
        _reference = reference;
        _word = word;
    }

    public void HideRandomWords()
    {
        _word.Hide();
        _word.Show();
    }

    public string GetDisplayText()
    {
        string wordText = $"{_reference.GetDisplayText()}\n{_word.GetDisplayText()}";
        return wordText;
    }

    public bool IscompletelyHidden()
    {
       return _word.IsHidden();
    }
        
}



