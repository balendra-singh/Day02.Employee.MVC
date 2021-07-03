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
       
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Jobprofile> Jobprofile { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user id=root;database=EmployeeDb;password=root;charset=utf8;connect timeout=5", x => x.ServerVersion("8.0.25-mysql"));
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Employee>(entity =>
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

            modelBuilder.Entity<Jobprofile>(entity =>
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
