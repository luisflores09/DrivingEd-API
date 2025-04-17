using System;
using System.Collections.Generic;
using System.Linq;
using DrivingEd_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace DrivingEd_BackEnd.Data;

public static class SeedUser
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            // Admins
            new User
            {
                Id = 1,
                UserName = "admin1",
                FirstName = "Admin",
                LastName = "One",
                Email = "admin1@example.com",
                Password = "Admin@123",
                PhoneNumber = "1234567890",
                Role = UserRole.Admin,
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 4,
                UserName = "admin2",
                FirstName = "Admin",
                LastName = "Two",
                Email = "admin2@example.com",
                Password = "Admin@123",
                PhoneNumber = "2234567890",
                Role = UserRole.Admin,
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 5,
                UserName = "admin3",
                FirstName = "Admin",
                LastName = "Three",
                Email = "admin3@example.com",
                Password = "Admin@123",
                PhoneNumber = "3234567890",
                Role = UserRole.Admin,
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 6,
                UserName = "admin4",
                FirstName = "Admin",
                LastName = "Four",
                Email = "admin4@example.com",
                Password = "Admin@123",
                PhoneNumber = "4234567890",
                Role = UserRole.Admin,
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },

            // Instructors
            new User
            {
                Id = 2,
                UserName = "instructor1",
                FirstName = "Instructor",
                LastName = "One",
                Email = "instructor1@example.com",
                Password = "Instructor@123",
                PhoneNumber = "0987654321",
                Role = UserRole.Instructor,
                LicenseNumber = "LIC12345",
                VehicleDetails = "Toyota Corolla",
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 7,
                UserName = "instructor2",
                FirstName = "Instructor",
                LastName = "Two",
                Email = "instructor2@example.com",
                Password = "Instructor@123",
                PhoneNumber = "1987654321",
                Role = UserRole.Instructor,
                LicenseNumber = "LIC12346",
                VehicleDetails = "Honda Civic",
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 8,
                UserName = "instructor3",
                FirstName = "Instructor",
                LastName = "Three",
                Email = "instructor3@example.com",
                Password = "Instructor@123",
                PhoneNumber = "2987654321",
                Role = UserRole.Instructor,
                LicenseNumber = "LIC12347",
                VehicleDetails = "Ford Focus",
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 9,
                UserName = "instructor4",
                FirstName = "Instructor",
                LastName = "Four",
                Email = "instructor4@example.com",
                Password = "Instructor@123",
                PhoneNumber = "3987654321",
                Role = UserRole.Instructor,
                LicenseNumber = "LIC12348",
                VehicleDetails = "Chevrolet Malibu",
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },

            // Students
            new User
            {
                Id = 3,
                UserName = "student1",
                FirstName = "Student",
                LastName = "One",
                Email = "student1@example.com",
                Password = "Student@123",
                PhoneNumber = "1122334455",
                Role = UserRole.Student,
                Address = "123 Main St",
                DateOfBirth = new DateTime(2000, 1, 1),
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 10,
                UserName = "student2",
                FirstName = "Student",
                LastName = "Two",
                Email = "student2@example.com",
                Password = "Student@123",
                PhoneNumber = "2122334455",
                Role = UserRole.Student,
                Address = "456 Elm St",
                DateOfBirth = new DateTime(2001, 2, 2),
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 11,
                UserName = "student3",
                FirstName = "Student",
                LastName = "Three",
                Email = "student3@example.com",
                Password = "Student@123",
                PhoneNumber = "3122334455",
                Role = UserRole.Student,
                Address = "789 Pine St",
                DateOfBirth = new DateTime(2002, 3, 3),
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = 12,
                UserName = "student4",
                FirstName = "Student",
                LastName = "Four",
                Email = "student4@example.com",
                Password = "Student@123",
                PhoneNumber = "4122334455",
                Role = UserRole.Student,
                Address = "101 Maple St",
                DateOfBirth = new DateTime(2003, 4, 4),
                ProfilePictureUrl = "https://cdn-icons-png.flaticon.com/512/149/149071.png",
                CreatedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            }
        );
    }
}
