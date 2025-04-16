using Microsoft.AspNetCore.Mvc;
using DrivingEd_BackEnd.Models;
using DrivingEd_BackEnd.Data;

namespace DrivingEd_BackEnd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly DrivingEdDbContext _context;

    public UserController(DrivingEdDbContext context)
    {
        _context = context;
    }

    // GET: api/User
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }

    // GET: api/User/{id}
    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    // POST: api/User
    [HttpPost]
    public IActionResult CreateUser([FromBody] User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    // PUT: api/User/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
    {
        if (id != updatedUser.Id)
        {
            return BadRequest("User ID mismatch.");
        }

        var user = _context.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }

        // Update user properties
        user.Name = updatedUser.Name;
        user.Email = updatedUser.Email;
        user.Password = updatedUser.Password;
        user.PhoneNumber = updatedUser.PhoneNumber;
        user.Role = updatedUser.Role;
        user.Privileges = updatedUser.Privileges;
        user.Expertise = updatedUser.Expertise;
        user.Availability = updatedUser.Availability;
        user.LicenseNumber = updatedUser.LicenseNumber;
        user.VehicleDetails = updatedUser.VehicleDetails;
        user.ProfilePictureUrl = updatedUser.ProfilePictureUrl;
        user.Bio = updatedUser.Bio;
        user.Address = updatedUser.Address;
        user.DateOfBirth = updatedUser.DateOfBirth;
        user.EmergencyContactName = updatedUser.EmergencyContactName;
        user.EmergencyContactPhone = updatedUser.EmergencyContactPhone;
        user.IsEnrolled = updatedUser.IsEnrolled;
        user.EnrollmentDate = updatedUser.EnrollmentDate;

        _context.SaveChanges();
        return NoContent();
    }

    // DELETE: api/User/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }

        _context.Users.Remove(user);
        _context.SaveChanges();
        return NoContent();
    }

    // GET: api/User/role/{role}
    [HttpGet("role/{role}")]
    public IActionResult GetUsersByRole(UserRole role)
    {
        var users = _context.Users.Where(u => u.Role == role).ToList();
        return Ok(users);
    }
}