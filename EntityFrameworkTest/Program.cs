using System;
using System.Data.SqlClient;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main()
        {
           using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine($"{count} records saved to database. \r\n");

                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($" - {blog.Url}");
                }
            }
        }
    }
}
