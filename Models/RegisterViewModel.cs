using System.ComponentModel.DataAnnotations;

namespace Assignment__1.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Does not match")]
        [Required]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
    }
}
