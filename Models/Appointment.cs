using System;

namespace DrivingEd_BackEnd.Models;

public class Appointment : BaseEntity
{
    public int InstructorId { get; set; }
    public User? Instructor { get; set; }
    public int StudentId { get; set; }
    public User? Student { get; set; }
    public DateTime DateTime { get; set; }
    public TimeSpan Duration { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public AppointmentStatus Status { get; set; }
    public bool IsCancelled { get; set; } = false;
}

public enum AppointmentStatus
{
    Pending,
    Confirmed,
    Completed,
    Cancelled,
    Rescheduled
}