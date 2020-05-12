using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data_Layer.Data
{
    public partial class F20ST4PRJ4TeleMedDatabaseContext : DbContext
    {
        public F20ST4PRJ4TeleMedDatabaseContext()
        {
        }

        public F20ST4PRJ4TeleMedDatabaseContext(DbContextOptions<F20ST4PRJ4TeleMedDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ECGLeads> ECGLeads { get; set; }
        public virtual DbSet<ECGMeasurements> ECGMeasurements { get; set; }
        public virtual DbSet<PatientMeasurements> PatientMeasurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=st-i4dab.uni.au.dk; Initial Catalog=F20ST4PRJ4TeleMedDatabase;Persist Security Info=True; User ID=F20ST4PRJ4TeleMedDatabase; Password=F20ST4PRJ4TeleMedDatabase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ECGLeads>(entity =>
            {
                entity.HasKey(e => e.ECGLeadId);

                entity.HasIndex(e => e.ECGMeasurementId);

                entity.HasOne(d => d.ECGMeasurement)
                    .WithMany(p => p.ECGLeads)
                    .HasForeignKey(d => d.ECGMeasurementId);
            });

            modelBuilder.Entity<ECGMeasurements>(entity =>
            {
                entity.HasKey(e => e.ECGMeasurementId);

                entity.HasIndex(e => e.PatientMeasurementId);

                entity.HasOne(d => d.PatientMeasurement)
                    .WithMany(p => p.ECGMeasurements)
                    .HasForeignKey(d => d.PatientMeasurementId);
            });

            modelBuilder.Entity<PatientMeasurements>(entity =>
            {
                entity.HasKey(e => e.PatientMeasurementId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
