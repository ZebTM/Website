using System.ComponentModel.DataAnnotations;


namespace Website.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}

