using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Assignment__1.Models
{
    public class User:IdentityUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        [Required]
        public string? UserEmail { get; set; }
    }
}
