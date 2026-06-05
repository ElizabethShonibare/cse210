using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Python Basics Tutorial", "CodeMaster", 900);
        Video video2 = new Video("Top 10 Travel Destinations", "TravelTime", 720);
        Video video3 = new Video("Easy Pasta Recipe", "Chef Emma", 480);
        Video video4 = new Video("Gaming Highlights 2025", "GameZone", 1200);

        // Add comments for video1
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Bob", "I finally understand classes."));
        video1.AddComment(new Comment("Charlie", "Great explanation."));
        video1.AddComment(new Comment("Diana", "Thanks for sharing!"));

        // Add comments for video2
        video2.AddComment(new Comment("Ethan", "Adding these to my bucket list."));
        video2.AddComment(new Comment("Fiona", "Amazing video quality!"));
        video2.AddComment(new Comment("George", "I visited Paris last year."));
        video2.AddComment(new Comment("Hannah", "Can't wait to travel."));

        // Add comments for video3
        video3.AddComment(new Comment("Ian", "This recipe was delicious."));
        video3.AddComment(new Comment("Julia", "Easy to follow instructions."));
        video3.AddComment(new Comment("Kevin", "My family loved it."));

        // Add comments for video4
        video4.AddComment(new Comment("Liam", "Awesome gameplay!"));
        video4.AddComment(new Comment("Mia", "That final move was incredible."));
        video4.AddComment(new Comment("Noah", "Looking forward to more videos."));
        video4.AddComment(new Comment("Olivia", "Best gaming channel!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.GetFormattedLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}