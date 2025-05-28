using System;

public class Video
// This class has the responsibility to store a list of comments and should have a method to return the number of
// comments.
{
    public List<string> _comments = new List<string>();

    public void GetComment(List<Comment>commentInfo)
    {
        foreach(Comment comment in commentInfo)
        {
            string text = comment._text;
            _comments.Add(text);
        }
    }

    public void NumberOfComment()
    {
       int number = _comments.Count;
       Console.WriteLine($"There are {number} comments.");
    }

    public void Display()
    {
        foreach(string comment in _comments)
        {
            Console.WriteLine($"The comment is: {comment}");
        }
    }
}