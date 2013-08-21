using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainClasses;
using Pluralsight.DataLayer;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateBlog();
            AddPost();
            Console.Write("That's all folks...");
            Console.ReadKey();
        }

        private static void AddPost() {
            var db = new Context();
            var blog = db.Blogs.Find(1);
            blog.Posts.Add(new Post{
                Title = "My First Post",
                Content = "Let's keep this short"});
            db.SaveChanges();
        }

        private static void CreateBlog()
        {
            var blog = new Blog { BloggerName = "Julie", Title = "EF41 Blog" };
            var db = new Context();
            db.Blogs.Add(blog);
            db.SaveChanges();
        }
    }
}
