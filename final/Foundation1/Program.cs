using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create videos
        Video video1 = new Video("Top 10 Monkey Moments", "Monkey Channel", 1800);
        Video video2 = new Video("Cheap Cooking Tutorial (using a budget)", "Rordan Gamsey", 3000);
        Video video3 = new Video("My Experiences as a Tourist Abroad...", "Travel-ugh", 2500);

        // Add comments to video1
        video1.AddComment(new Comment("Eve", "Super funny! XD"));
        video1.AddComment(new Comment("Dave", "Absolutely Fantastic! Definatealy my favorite animal."));
        video1.AddComment(new Comment("Hank", "I saw about this on the news. You shouldn't make fun of people like this."));

        // Add comments to video2
        video2.AddComment(new Comment("Grace", "Fantastic techniques! I'll have to prepare something for my roommates!"));
        video2.AddComment(new Comment("Danielle", "I love cooking!"));
        video2.AddComment(new Comment("Abraham", "Very helpful, thanks! Glad I can afford most of this stuff!"));

        // Add comments to video3
        video3.AddComment(new Comment("Stephan", "I learned a lot from this thanks. Definitely not going to LA."));
        video3.AddComment(new Comment("Emma", "Anyone else feel like this is a little unfair a criticism? Ive been to several of these locations and if you have a local it solves most of his issues..."));
        video3.AddComment(new Comment("Sally", "Always entertaining lol!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }
    }
}
