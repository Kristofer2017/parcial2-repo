using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Parcial02.Entities;

#nullable disable

namespace Parcial02
{
    public partial class UCAClinicContext : DbContext
    {
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        
        public UCAClinicContext()
        {
            
        }

        public UCAClinicContext(DbContextOptions<UCAClinicContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=UCAClinic;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speciality>().Property(s => s.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Reservation>().Property(r => r.id).ValueGeneratedOnAdd();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
