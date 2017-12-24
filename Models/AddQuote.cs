using System.ComponentModel.DataAnnotations;
 
namespace quotable.Models
{
    public class Quote
    {
        public int QuoteId {get; set;}
        public string Author { get; set; }

        private string quote { get; set; }
    }
}