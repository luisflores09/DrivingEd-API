using System;
using Microsoft.EntityFrameworkCore;
using DrivingEd_BackEnd.Models;


namespace DrivingEd_BackEnd.Data
{

    public class DrivingEdDbContext : DbContext
    {
        public DrivingEdDbContext(DbContextOptions<DrivingEdDbContext> options) : base(options) { }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}