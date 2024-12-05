class Program
{
    static void Main(string[] args)
    {
        // Criar vídeos
        Video video1 = new Video { _title = "Video 1", _author = "Author 1", _length = 10 };
        Video video2 = new Video { _title = "Video 2", _author = "Author 2", _length = 20 };
        Video video3 = new Video { _title = "Video 3", _author = "Author 3", _length = 30 };
        Video video4 = new Video { _title = "Video 4", _author = "Author 4", _length = 40 };

        // Adicionar comentários aos vídeos
        video1._comments.Add(new Comment { _name = "Author 1", _commentText = "nice video" });
        video1._comments.Add(new Comment { _name = "Author 2", _commentText = "I like this video" });

        video2._comments.Add(new Comment { _name = "Author 3", _commentText = "it's ok" });
        video2._comments.Add(new Comment { _name = "Author 4", _commentText = "nothing" });

        video3._comments.Add(new Comment { _name = "Author 5", _commentText = "try hard" });
        video3._comments.Add(new Comment { _name = "Author 6", _commentText = "not bad" });

        video4._comments.Add(new Comment { _name = "Author 7", _commentText = "it's waste" });

        // Lista de vídeos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Exibir informações sobre os vídeos e seus comentários
        foreach (Video vid in videos)
        {
            Console.WriteLine($"Title: {vid._title}, Author: {vid._author}, Length: {vid._length} seconds, Comments: {vid.GetViewsVideoCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment com in vid._comments)
            {
                Console.WriteLine($"- {com.GetCommentInfo()}");
            }

            Console.WriteLine();
        }
    }
}
