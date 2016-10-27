using System.ComponentModel.DataAnnotations;

namespace Mlb5.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}