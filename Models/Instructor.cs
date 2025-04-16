using System;
using System.Collections.Generic; // Ensure List is recognized
using DrivingEd_BackEnd.Models; // Ensure Appointment is recognized

namespace DrivingEd_BackEnd.Models;

public class Instructor : User
{
    public string Expertise { get; set; } = string.Empty;
    public string Availability { get; set; } = string.Empty;
    public List<Appointment> BookedAppointments { get; set; } = new();
}