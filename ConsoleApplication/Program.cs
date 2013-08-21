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
            CreateBlog();
            Console.Write("That's all folks...");
            Console.ReadKey();
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
