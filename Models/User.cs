using System;

namespace DrivingEd_BackEnd.Models;

public enum UserRole
{
    Admin,
    Instructor,
    Student
}

public class User : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public List<string>? Privileges { get; set; }
    public string? Expertise { get; set; }
    public string? Availability { get; set; }
    public string? LicenseNumber { get; set; }
    public string? VehicleDetails { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public string? Bio { get; set; }
    public string? Address { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? EmergencyContactName { get; set; }
    public string? EmergencyContactPhone { get; set; }
    public bool? IsEnrolled { get; set; }
    public DateTime? EnrollmentDate { get; set; }
}