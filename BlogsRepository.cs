using System;
using System.Linq;
using EFPart1.DataModels;
using Microsoft.EntityFrameworkCore;

namespace EFPart1
{
    public class Repository : IBlog
    {

        public void displayBlog()
        {
            using (var db = new BloggingContext())
            {
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($"({blog.BlogId}) || {blog.Url}");
                }
            }
        }

        
        public void createBlog()
        {
           //insert to blog db
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Enter name for a new blog:");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.AddBlog(blog);
                
                var query = db.Blogs.OrderBy(b => b.Name);

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                


                //var name = Console.ReadLine();

                // var blog = new Blog()
                // {
                    // Rating = 1,
                    // Url = "some/Url"
                // };
                
                db.Blogs.Add(blog);
                db.SaveChanges(); 
            }
        }

        public void displayPost()
        {
           int blogID = 0;

            System.Console.Write("Enter blog ID: ");
            blogID = Int32.Parse(Console.ReadLine());

            using(var db = new BloggingContext())
             {
                 var blog = db.Blogs
                    .Include(b => b.Posts)
                    .ToList()
                    .Find(b => b.BlogId == blogID);
                
                var posts = blog.Posts.ToArray();

                foreach (var post in posts)
                {
                    Console.WriteLine($"{post.Blog.Url,-10} | {post.Title,-20} | {post.Content}");
                }
                System.Console.WriteLine();

                }    
        }

        public void insertPost()
        {
            //insert to post db
            int blogID = 0;

            System.Console.Write("Enter blog ID: ");
            blogID = Int32.Parse(Console.ReadLine());

            using (var db = new BloggingContext())
            {
                var blog = db.Blogs
                .Include(b => b.Posts)
                .ToList()
                .Find(b => b.BlogId == blogID);
                
                var post = new Post()
                {
                    BlogId = 1,
                    Content = "Some stuff",
                    Title = "aaaa"
                };

                db.Posts.Add(post);
                db.SaveChanges();
            }
        }

       
    }
}