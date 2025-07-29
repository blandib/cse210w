using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();
        videos.Add(CreateVideo("How to Cook Pasta", "Chef Mario", 300, new List<Comment>
        {
            new Comment("Alice", "This was super helpful!"),
            new Comment("Bob", "I love pasta "),
            new Comment("Charlie", "Clear instructions, thanks!")
        }));

        videos.Add(CreateVideo("Learn C# in 10 Minutes", "CodeMaster", 600, new List<Comment>
        {
            new Comment("Dave", "Perfect for beginners."),
            new Comment("Eve", "I learned a lot!"),
            new Comment("Frank", "Can you do one for Java?")
        }));

        videos.Add(CreateVideo("Top 10 Travel Destinations", "Wanderlust", 450, new List<Comment>
        {
            new Comment("Grace", "I want to visit all these places!"),
            new Comment("Heidi", "Great visuals."),
            new Comment("Ivan", "Loved the narration.")
        }));

        videos.Add(CreateVideo("Daily Devotional", "FaithTalks", 240, new List<Comment>
        {
            new Comment("Judy", "Very uplifting message."),
            new Comment("Ken", "Shared this with my Bible study group."),
            new Comment("Laura", "Thank you for this.")
        }));

        // Display video info
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }

    static Video CreateVideo(string title, string author, int length, List<Comment> comments)
    {
        Video video = new Video(title, author, length);
        foreach (var comment in comments)
        {
            video.AddComment(comment);
        }
        return video;
    }
}
    
