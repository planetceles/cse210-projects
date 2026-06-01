using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn HTML Basics", "CalcCode", 600);
        video1.AddComment(new Comment("Celeste", "Very helpful video!"));
        video1.AddComment(new Comment("John", "Thanks for the clear explanation!"));
        video1.AddComment(new Comment("Michael", "Thank you sir, I needed this!"));

        videos.Add(video1);

        Video video2 = new Video("CSS Tutorial for Beginners", "CalcCode", 500);
        video2.AddComment(new Comment("Emma", "More videos like this please!"));
        video2.AddComment(new Comment("Sylvie", "Can you please explain about FlexBox?!"));
        video2.AddComment(new Comment("David", "Well explained, thank you!"));

        videos.Add(video2);

        Video video3 = new Video("JavaScript Tutorial", "CalcCode", 900);
        video3.AddComment(new Comment("Sophia", "This video helped me a lot"));
        video3.AddComment(new Comment("Lisa", "Great content, very helpful"));
        video3.AddComment(new Comment("James", "I finally understand JavaScript, thanks"));

        videos.Add(video3);

        Video video4 = new Video("Python Programming for Beginners", "CalcCode", 1050);
        video4.AddComment(new Comment("Olivia", "This is a great explanation"));
        video4.AddComment(new Comment("Grace", "This is a great explanation, thank you"));
        video4.AddComment(new Comment("Mike", "Wow! This is a great explanation"));

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");

            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}