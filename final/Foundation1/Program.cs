using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(new Comment("John", "what a fun video!"));
        comments1.Add(new Comment("Mary", "how is that even possible?"));
        comments1.Add(new Comment("Luke", "I was first"));
        Video video1 = new Video("Running Through Glass", "Mr. Random", 180, comments1);
        videos.Add(video1);

        List<Comment> comments2 = new List<Comment>();
        comments2.Add(new Comment("John", "first"));
        comments2.Add(new Comment("Mary", "second"));
        comments2.Add(new Comment("Luke", "first"));
        Video video2 = new Video("Hello World in C#", "Mister Random", 300, comments2);
        videos.Add(video2);

        List<Comment> comments = new List<Comment>();
        comments.Add(new Comment("John", "This is a comment."));
        comments.Add(new Comment("Mary", "This is another comment."));
        comments.Add(new Comment("Luke", "This is a third comment."));
        Video video3 = new Video("Video Title", "Video Creator", 60, comments);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.Display(v);
        }
    }
}