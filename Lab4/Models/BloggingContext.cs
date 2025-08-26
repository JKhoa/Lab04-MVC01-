using System.Data.Entity;

namespace Lab4.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        
        // Optional: Configure connection string
        public BloggingContext() : base("DefaultConnection")
        {
        }
    }
}