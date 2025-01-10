namespace Donate.Data.Entities;

public class ViewProject
{
    public int Id { get; set; }
    
    public int OrganizationId { get; set; }
    public string? Organization { get; set; }

    public string? Title { get; set; } 

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool Active { get; set; } 

    public ProjectStatus Status { get; set; } 
}
