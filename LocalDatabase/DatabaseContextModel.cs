//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Databases;
using Microsoft.EntityFrameworkCore;

namespace Databases
{
    
    public class LocalDBContext : DbContext
    {
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
        public DbSet<ECGLead> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=LocalDb_Version1.db"); // Åbner forbindelse til database og holder øje med at der er konsistens mellem database og koden
    }

    //public class TeleDBContext : DbContext
    //{
    //    public DbSet<PatientMeasurement> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
    //    public DbSet<ECGMeasurement> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
    //    public DbSet<ECGLead> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //        => options.UseSqlite("Data Source=TeleDB_Version1.db"); // Åbner forbindelse til database og holder øje med at der er konsistens mellem database og koden
    //}



    
}
