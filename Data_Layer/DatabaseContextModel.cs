//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer
{
    
    public class LocalDBContext : DbContext
    {
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
        public DbSet<ECGLead> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=LocalDb_Version2.db"); // Åbner forbindelse til database og holder øje med at der er konsistens mellem database og koden
    }

    public class TeleDBContext : DbContext
    {
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
        public DbSet<ECGLead> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

        private const String _database = "F20ST4PRJ4TeleMedDatabase";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=st-i4dab.uni.au.dk; Initial Catalog=" + _database + "; " +
                                 "Persist Security Info=True; User ID=" + _database + "; Password=" + _database + "");
        } // Åbner forbindelse til database og holder øje med at der er konsistens mellem database og koden
    }




}
