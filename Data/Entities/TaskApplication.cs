namespace Donate.Data.Entities;

public class TaskApplication
{
    public int Id { get; set; }

    public int VolunteerId { get; set; }
    public AppUser? Volunteer { get; set; }

    public int ProjectTaskId { get; set; }
    public ProjectTask? ProjectTask { get; set; }

    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
}

public enum ApplicationStatus
{
    Pending,
    Approved,
    Rejected,
}