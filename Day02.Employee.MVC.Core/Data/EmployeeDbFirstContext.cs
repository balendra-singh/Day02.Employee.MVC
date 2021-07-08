using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day02.Employee.MVC.Core.Data
{
    public partial class EmployeeDbFirstContext : DbContext
    {
        public EmployeeDbFirstContext()
        {
        }

        public EmployeeDbFirstContext(DbContextOptions<EmployeeDbFirstContext> options)
            : base(options)
        {
        }
       
        public virtual DbSet<EmployeeEntity> EmployeeEntities { get; set; }
        public virtual DbSet<JobProfileEntity> JobProfileEntities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<EmployeeEntity>(entity =>
            {
                entity.HasKey(e => e.EmployeeCode)
                    .HasName("PRIMARY");

                entity.Property(e => e.AddressLine1)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AddressLine2)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.City)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PinCode)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<JobProfileEntity>(entity =>
            {
                entity.Property(e => e.JobProfileName)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
