using System.ComponentModel.DataAnnotations.Schema;

namespace Donate.Data.Entities;

public class ViewProjectTask
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public string? Project { get; set; }

    public int WantedCount { get; set; }
    public string? Description { get; set; } 

    public DateTime Date { get; set; } 

    public TaskStatus Status { get; set; }

    public int ApplicationCount { get; set; }
    public int ApprovedApplicationCount { get; set; }
    
    public string? VolunteerIds { get; set; } = "";
    public bool Active { get; set; } = true;

    [NotMapped]
    public AppUser[] Applications { get; set; } = [];
}

