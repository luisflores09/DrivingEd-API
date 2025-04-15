using System;

namespace DrivingEd_BackEnd.Models;

public class Instructor : User
{
    public string Expertise { get; set; } = string.Empty;
    public string Availability { get; set; } = string.Empty;
    public List<DateTime> BookedAppointments { get; set; } = new();
}