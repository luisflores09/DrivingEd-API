using Microsoft.EntityFrameworkCore;
using DrivingEd_BackEnd.Models;

namespace DrivingEd_BackEnd.Data;

public class DrivingEdDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    public DrivingEdDbContext(DbContextOptions<DrivingEdDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SeedUser.Seed(modelBuilder);
        // Configure Appointment foreign keys
        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Instructor)
            .WithMany()
            .HasForeignKey(a => a.InstructorId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Student)
            .WithMany()
            .HasForeignKey(a => a.StudentId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
    }
}