using Microsoft.EntityFrameworkCore;

namespace quotable.Models

{
    public class QuoteContext:DbContext
    {
        public QuoteContext(DbContextOptions<QuoteContext> options):base(options){

        }
    public DbSet<user> Users { get; set; }
    }
}