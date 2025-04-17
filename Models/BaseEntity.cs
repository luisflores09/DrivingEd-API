using System;

namespace DrivingEd_BackEnd.Models;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; } // Tracks when the entity was last updated
    public bool IsDeleted { get; set; } = false; // Soft delete flag
    public string? CreatedBy { get; set; } // Tracks the user who created the entity
    public string? UpdatedBy { get; set; } // Tracks the user who last updated the entity
}