using Microsoft.AspNetCore.Mvc;
using DrivingEd_BackEnd.Models;
using DrivingEd_BackEnd.Data;
using Microsoft.EntityFrameworkCore;

namespace DrivingEd_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly DrivingEdDbContext _context;

        public AppointmentController(DrivingEdDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _context.Appointments
                .Include(a => a.Instructor)
                .Include(a => a.Student)
                .ToListAsync();
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var appointment = await _context.Appointments
                .Include(a => a.Instructor)
                .Include(a => a.Student)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appointment == null)
            {
                return NotFound($"Appointment with ID {id} not found.");
            }

            return Ok(appointment);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment([FromBody] Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = await _context.Users.FindAsync(appointment.StudentId);
            var instructor = await _context.Users.FindAsync(appointment.InstructorId);

            if (student == null)
            {
                return BadRequest("Invalid Student ID.");
            }

            if (instructor == null)
            {
                return BadRequest("Invalid Instructor ID.");
            }

            appointment.Student = student;
            appointment.Instructor = instructor;

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAppointmentById), new { id = appointment.Id }, appointment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppointment(int id, [FromBody] Appointment updatedAppointment)
        {
            if (id != updatedAppointment.Id)
            {
                return BadRequest("Appointment ID mismatch.");
            }

            var existingAppointment = await _context.Appointments.FindAsync(id);
            if (existingAppointment == null)
            {
                return NotFound($"Appointment with ID {id} not found.");
            }

            // Update fields
            existingAppointment.DateTime = updatedAppointment.DateTime;
            existingAppointment.Location = updatedAppointment.Location;
            existingAppointment.Notes = updatedAppointment.Notes;
            existingAppointment.Status = updatedAppointment.Status;
            existingAppointment.IsCancelled = updatedAppointment.IsCancelled;

            await _context.SaveChangesAsync();
            return Ok(existingAppointment);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound($"Appointment with ID {id} not found.");
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}