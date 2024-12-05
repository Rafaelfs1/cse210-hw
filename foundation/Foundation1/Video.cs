public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }

    // Lista de comentários associados a este vídeo
    public List<Comment> _comments = new List<Comment>();

    // Método para obter a contagem de comentários deste vídeo
    public int GetViewsVideoCount()
    {
        return _comments.Count;
    }

    public string GetVideoInfo()
    {
        return $"{_title} by {_author} ({_length} seconds)";
    }
}
