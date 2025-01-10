namespace Donate.Data.Entities;

public class ProjectTask
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public virtual Project? Project { get; set; }

    public int WantedCount { get; set; }
    public string Description { get; set; } = string.Empty;

    public DateTime Date { get; set; } = DateTime.UtcNow;

    public TaskStatus Status { get; set; } = TaskStatus.Pending;
    public bool Active { get; set; } = true;
}

public enum TaskStatus
{
    Ongoing,
    Completed,
    Pending,
}