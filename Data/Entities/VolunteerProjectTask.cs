namespace Donate.Data.Entities;

public class VolunteerProjectTask
{
    public int ProjectTaskId { get; set; }
    public ProjectTask? Task { get; set; }

    public int VolunteerId { get; set; }
    public AppUser? Volunteer { get; set; }
}
