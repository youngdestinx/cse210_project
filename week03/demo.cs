
using System;

public class Scripture
// It responsibilities is to manage the full scripture (reference + word), handle display and control hiding logic
{
    private Reference _reference;
    private Word _word;

    public Scripture(Reference reference, Word word)
    {
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            _word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string wordText = $"{_reference.GetDisplayText()}:\n{_word.GetDisplayText}";
        return wordText;
    }

    public bool IscompletelyHidden()
    {
        
    }
        
}



