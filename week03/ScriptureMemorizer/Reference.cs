
using System;

public class Reference
// This class represent the reference of the scripture. It stores book name, chapter and verse.
// It has multiple constructors that can handle single verse and multiple verses.
// It responsibility is to store book names and verses and returned them in a formatted scriptural way.

{
    private string _book; 
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
            if (_endVerse != 0)
            {
                string text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
                return text;
            }
            else 
            {
                string text = $"{_book} {_chapter}:{_startVerse}";
                return text;
            }
            
    }

}
