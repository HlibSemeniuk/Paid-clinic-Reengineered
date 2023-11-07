using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class ClinicContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Treatment> Treatments { get; set; }

        public ClinicContext() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=PaidClinic;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasIndex(u => new { u.Name, u.Password}).IsUnique();
            modelBuilder.Entity<Doctor>().HasIndex(u => new { u.Name, u.Password }).IsUnique();
            modelBuilder.Entity<Appointment>().HasIndex(a => a.Date).IsUnique();

            modelBuilder.Entity<Doctor>().HasData(
        new Doctor { ID = 1, Name = "Ольга Бондарчук", Birthdate = new DateTime(1970, 1, 1), Password = "password", Specialization = "Стоматолог" });

            modelBuilder.Entity<Patient>().HasData(
                new Patient { ID = 1, Name = "Олександр Птаха", Birthdate = new DateTime(1990, 1, 1), Password = "password", SocialDiscount = true }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { ID = 1, Date = new DateTime(2023, 3, 25), IsHappened = false, DoctorID = 1, PatientID = 1 }
            );


        }
    }
}