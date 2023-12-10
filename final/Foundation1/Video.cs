public class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public int _count = 0;
    public List<Comment> _comments = new List<Comment>();


    public int GetNumberOfComments()
    {
        foreach(Comment comment in _comments)
        {
            _count += 1; 
        }
        return _count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
           Console.WriteLine($"—{comment._name}: {comment._commentText}"); 
        }
    }

}