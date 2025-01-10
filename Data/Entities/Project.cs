using System.ComponentModel.DataAnnotations;

namespace Donate.Data.Entities;

public class Project
{
    public int Id { get; set; }

    [Required]
    public int OrganizationId { get; set; }
    public virtual AppUser? Organization { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool Active { get; set; } = true;

    public ProjectStatus Status { get; set; } = ProjectStatus.Pending;

    //public ICollection<ProjectTask> Tasks { get; set; } = [];
}

public enum ProjectStatus
{
    Pending,
    Ongoing,
    Completed,
}