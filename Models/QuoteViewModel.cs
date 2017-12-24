using System.ComponentModel.DataAnnotations;

namespace quotable.Models
{
    public class QuoteViewModel
    {
        [Required]
        [MinLength(2)]
        [Display(Name="Author")]
        public string Author { get; set;}
        
        [Required]
        [MinLength(2)]
        [Display(Name="Quote")]
        public string Quote { get; set;}        
    }
}