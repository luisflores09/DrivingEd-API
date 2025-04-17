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

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }

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

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] User updatedUser)
    {
        var existingUser = await _context.Users.FindAsync(id);
        if (existingUser == null)
        {
            return NotFound($"User with ID {id} not found.");
        }

        // Update only the fields that are not null or empty
        existingUser.FirstName = !string.IsNullOrWhiteSpace(updatedUser.FirstName) ? updatedUser.FirstName : existingUser.FirstName;
        existingUser.LastName = !string.IsNullOrWhiteSpace(updatedUser.LastName) ? updatedUser.LastName : existingUser.LastName;
        existingUser.Email = !string.IsNullOrWhiteSpace(updatedUser.Email) ? updatedUser.Email : existingUser.Email;
        existingUser.Role = updatedUser.Role != 0 ? updatedUser.Role : existingUser.Role;

        await _context.SaveChangesAsync();
        return Ok(existingUser);
    }

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