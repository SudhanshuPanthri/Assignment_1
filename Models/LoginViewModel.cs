using System.ComponentModel.DataAnnotations;

namespace Assignment__1.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please enter Email Address")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
