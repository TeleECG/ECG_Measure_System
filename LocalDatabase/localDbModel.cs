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
        public DbSet<Patient> Patients { get; set; }
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; }
        public DbSet<ECGLead> ECGLeads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=LocalPatientDbV1.db");
    }

    public class Patient // Patientklassen sendes i databasen med følgende: 
    {
        public int PatientId { get; set; } //Et autogenerede Id-nummer, der kun passer til den specifikke patient. 
        public string CPRNumber { get; set; } // CPR-nummer tilhørende patienten, som indtastes på brugergrænsefladen.
        public string Name { get; set; } // Navn tilhørende patienten, som indtastes på brugergrænsefladen.
        public string Address { get; set; } // Adresse tilhørende patienten, som indtastes på brugergrænsefladen.
        public DateTime Date { get; set; } // Autogenereret dato, der passer til tidspunktet dataen flyttes til databasen. 
        public int Pulse { get; set; } // Patientens puls, som er udregnet ud fra den målte EKG data.
        public int HRV { get; set; } // Patientens HRV, som er udregnet ud fra den målte EKG data.
        public List<ECGMeasurement> ECGMeasurements { get; } = new List<ECGMeasurement>(); // En liste bestående af objekter af klassen ECGMeasurement.
    }

    public class ECGMeasurement
    {
        public int ECGMeasurementId { get; set; }
        //public List<int> Values { get; set; } = new List<int>();
        public string Title { get; set; }
        public string Content { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public List<ECGLead> ECGLeads { get; set; } = new List<ECGLead>();
    }
    public class ECGLead
    {
        public int ECGLeadId { get; set; }
        public ECGMeasurement ECGMeasurement { get; set; }
        public int ECGMeasurementId { get; set; }
        public int LeadNumber { get; set; }
        public int ECGLeadValue { get; set; }
        //public List<double> ECGLeadValues { get; set; } = new List<double>();

    }


}
