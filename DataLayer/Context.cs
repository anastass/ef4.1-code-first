using System.Data.Entity;
using DomainClasses;
using System.Collections.Generic;

namespace Pluralsight.DataLayer
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }


}
