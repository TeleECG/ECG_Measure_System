using System;
using System.Linq;

namespace LocalDatabase
{
    class Program
    {
        static void Main()
        {
            //using (var db = new BloggingContext())
            //{
            //    // Create
            //    Console.WriteLine("Inserting a new blog");
            //    db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //    db.SaveChanges();

            //    // Read
            //    Console.WriteLine("Querying for a blog");
            //    var blog = db.Blogs
            //        .OrderBy(b => b.BlogId)
            //        .First();

            //    // Update
            //    Console.WriteLine("Updating the blog and adding a post");
            //    blog.Url = "https://devblogs.microsoft.com/dotnet";
            //    blog.Posts.Add(
            //        new Post
            //        {
            //            Title = "Hello World",
            //            Content = "I wrote an app using EF Core!"
            //        });
            //    db.SaveChanges();

            //    // Delete
            //    Console.WriteLine("Delete the blog");
            //    db.Remove(blog);
            //    db.SaveChanges();
            //}
            using (var db = new BloggingContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");

                var Patient = new Patient() { CPRNumber = "123456-1234", Name = "Inger", Pulse = 65 };
                var ECGM = new ECGMeasurement();
                var ECGLead = new ECGLead();
                var ECGLead1 = new ECGLead();
                var ECGLead2 = new ECGLead();
                ECGM.Title = "Test";
                ECGLead.LeadNumber = 1;
                ECGLead1.LeadNumber = 2;
                ECGLead2.LeadNumber = 3;
                ECGM.ECGLeads.Add(ECGLead);
                ECGM.ECGLeads.Add(ECGLead1);
                ECGM.ECGLeads.Add(ECGLead2);
                Patient.ECGMeasurements.Add(ECGM);
                db.Add(Patient);
                db.SaveChanges();


                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Patients
                    .OrderBy(b => b.PatientId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.CPRNumber = "123456-1234";
                blog.ECGMeasurements.Add(
                    new ECGMeasurement
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}
