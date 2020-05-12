using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.Data
{
    public class LocalDBContext : DbContext
    {
        public DbSet<PatientMeasurements> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
        public DbSet<ECGMeasurements> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
        public DbSet<ECGLeads> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=LocalDb_Version3.db"); // Åbner forbindelse til database og holder øje med at der er konsistens mellem database og koden
    }
}
