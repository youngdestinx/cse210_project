using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._name = "Ada";
        comment1._text = "This is a very interesting movie";

        Comment comment2 = new Comment();
        comment2._name = "Esther";
        comment2._text = "This is too boring";

        Comment comment3 = new Comment();
        comment3._name = "Faith";
        comment3._text = "I cried seeing this";

        Video vid = new Video();
        vid._comments.Add(comment1._text);
        vid._comments.Add(comment2._text);

        Video vid1 = new Video();
        vid1._comments.Add(comment3._text);
        vid1._comments.Add(comment1._text);
        vid1._comments.Add(comment2._text);

        Video vid3 = new Video();
        vid3._comments.Add(comment2._text);

        YouTubeVideos video1 = new YouTubeVideos();
        video1._title = "Merlin";
        video1._author = "Miracle";
        video1._length = 305;
        video1._video = vid;

        YouTubeVideos video2 = new YouTubeVideos();
        video2._title = "Legend of the seeker";
        video2._author = "Debby";
        video2._length = 498;
        video2._video = vid1;

        YouTubeVideos video3 = new YouTubeVideos();
        video3._title = "Avatar";
        video3._author = "Destiny";
        video3._length = 807;
        video3._video = vid3;

        List<YouTubeVideos> YouTube = new List<YouTubeVideos>();
        YouTube.Add(video1);
        YouTube.Add(video2);
        YouTube.Add(video3);

        foreach(YouTubeVideos video in YouTube)
        {
            video.Display();
            video.DisplayComment();
        }
    }
}