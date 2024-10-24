using ApiFront.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFront
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor_Pations>().HasKey(x => new {x.Pationid,x.Dcotorid});

            modelBuilder.Entity<Doctors>().HasMany(x => x.Doctor_Pations).WithOne(x => x.Doctor).HasForeignKey(x=>x.Dcotorid);

            modelBuilder.Entity<Patients>().HasMany(x=>x.Doctor_Pations).WithOne(x=>x.Patient).HasForeignKey(x=>x.Pationid);
        }

        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Doctor_Pations> Doctor_Pations { get; set; }
    }
}
