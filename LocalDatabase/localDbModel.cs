//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LocalDatabase
{
    //public class BloggingContext : DbContext
    //{
    //    public DbSet<Blog> Blogs { get; set; }
    //    public DbSet<Post> Posts { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //        => options.UseSqlite("Data Source=blogging.db");
    //}

    //public class Blog
    //{
    //    public int BlogId { get; set; }
    //    public string Url { get; set; }

    //    public List<Post> Posts { get; } = new List<Post>();
    //}

    //public class Post
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    public int BlogId { get; set; }
    //    public Blog Blog { get; set; }
    //}
    public class BloggingContext : DbContext
    {
        public DbSet<Patient> Blogs { get; set; }
        public DbSet<ECGMeasurement> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=LocalPatientDb.db");
    }

    public class Patient
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int Pulse { get; set; }
        public int HRV { get; set; }

        public List<ECGMeasurement> ECGMeasurements { get; } = new List<ECGMeasurement>();
    }

    public class ECGMeasurement
    {
        public int MeasurementId { get; set; }
        //public List<int> Values { get; set; } = new List<int>();
        public string Title { get; set; }
        public string Content { get; set; }
        public int ID { get; set; }
        public Patient Patient { get; set; }
    }
}
