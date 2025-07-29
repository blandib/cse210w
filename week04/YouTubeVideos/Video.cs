using System;
using System.Collections.Generic;

class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;
    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return comments.Count;
    }
    public string GetTitle()
    {
        return title;
    }
    public string GetAuthor()
    {
        return author;
    }
    public int GetLength()
    {
        return lengthInSeconds;
    }
    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }
}
