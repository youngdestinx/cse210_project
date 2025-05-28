using System;

public class Comment
// This has the responsibility for tracking both the name of the commenter and the text of the comment.
{
    public string _name;
    public string _text;

    public void Display()
    {
        string comment = $"Name of commenter: {_name}; comment of commenter: {_text}";
        Console.WriteLine(comment);        
    }
}