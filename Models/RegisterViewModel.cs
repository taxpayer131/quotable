using System.ComponentModel.DataAnnotations;

namespace quotable.Models
{
    public class RegisterViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName { get; set;}

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName { get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        public string Email { get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        [Compare("Password", ErrorMessage="Confirmed password does not match password.")]
        public string Confirm { get; set;}
    }
}