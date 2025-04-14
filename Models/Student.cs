using System;

namespace DrivingEd_BackEnd.Models;

public class Student : User
{
    public List<DateTime> BookedAppointments { get; set; } = new();
}