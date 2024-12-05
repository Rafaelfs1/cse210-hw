using System;

public class Comment
{
    public string _name;
    public string _commentText;

    public string _videoTitle;

    public List<string> _commentsVideo = new List<string>();

    public string GetCommentInfo()
    {
        return $"{_name}: {_commentText}"; 
    }
}