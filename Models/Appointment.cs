using System;

namespace DrivingEd_BackEnd.Models;

public class Appointment : BaseEntity
{
    public int InstructorId { get; set; }
    public int StudentId { get; set; }
    public DateTime DateTime { get; set; }
    public AppointmentStatus Status { get; set; }
}

public enum AppointmentStatus
{
    Pending,
    Confirmed,
    Cancelled
}