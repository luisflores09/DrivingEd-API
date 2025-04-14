using System;

namespace DrivingEd_BackEnd.Models;

public class Admin : User
{
    public List<string> Privileges { get; set; } = new();
}