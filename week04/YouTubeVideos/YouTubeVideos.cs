using System;

public class YouTubeVideos
// This class has the responsibility to track the title, author and length(in seconds) of the video
{
    public string _title;
    public string _author;
    public int _length;
    public Video _video = new Video();

    public void Display()
    {
       string videos = $"Title: {_title}; Author: {_author}; Length of video: {_length}secs";
        Console.WriteLine(videos);
    }

    public void DisplayComment()
    {
        _video.Display();

        _video.NumberOfComment();
    }

}