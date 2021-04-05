using System;
using System.Linq;
using EFPart1.DataModels;
using Microsoft.EntityFrameworkCore;

namespace EFPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //insert to blog db
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Enter a name for a new Blog: ");
                var name = Console.ReadLine();
                 var blog = new Blog()
                 {
                     Rating = 1,
                     Url = "some/Url"
                 };
                
                db.Blogs.Add(blog);
                db.SaveChanges(); 
            }

            //insert to post db
            using (var db = new BloggingContext())
            {
                var post = new Post()
                {
                    BlogId = 1,
                    Content = "Some stuff",
                    Title = "aaaa"
                };

                db.Posts.Add(post);
                db.SaveChanges();
            }

            //select from blog db
            using (var db = new BloggingContext())
            {
                 var blogs = db.Blogs
                        .Include(b => b.Posts)
                        .ToList(); 

                foreach (var blog in blogs)
                {
                   
                    System.Console.WriteLine("BLOGS");
                    System.Console.WriteLine($"({blog.BlogId}) {blog.Url}");

                    System.Console.WriteLine("POSTS");
                    foreach (var post in blog.Posts)
                    {
                        System.Console.WriteLine($"({post.PostId}) {post.Title} ");
                    }

                    System.Console.WriteLine();
                }
            }
            

        }
    }
}
