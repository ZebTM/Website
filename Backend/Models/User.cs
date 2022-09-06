namespace Models;
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
        
    }
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
    }