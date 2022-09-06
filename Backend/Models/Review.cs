namespace Models;

public class Review
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public string Title { get; set; }
    public int Upvotes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public Guid UserId { get; set; }
    public Category Category { get; set; } 
}