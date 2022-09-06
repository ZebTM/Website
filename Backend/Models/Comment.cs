namespace Models;

public class Comment
{
    public Guid Id { get; set;}
    public Guid UserId { get; set; }
    public string Content { get; set; }
    public int Upvotes { get; set; }
}