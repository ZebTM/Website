namespace Website.Models;

public class Review
{
    public String Data { get; set; } = String.Empty;
    public Guid Id { get; set; }
    public int Upvotes { get; set; } = 0;
    public int Downvotes { get; set; } = 0;

    public Guid UserId { get; set; }
    public User? User { get; set; }
}