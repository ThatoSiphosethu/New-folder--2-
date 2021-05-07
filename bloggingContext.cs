using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFPart1.DataModels
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs {get; set;}
        public DbSet<Post> Posts {get; set;}
        
        public void AddBlog(Blog blog)
        {
            this.Blogs.Add(blog);
            this.SaveChanges();
        }

        public void AddPost(Post post)
        {
            this.Posts.Add(post);
            this.SaveChanges();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=bitsql.wctc.edu;Database=tramalepa_22097_Movie;User ID=tramalepa;Password=000558972;");
        }

    }
}