using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Donate.Data.Entities;

public class AppUser : IdentityUser<int>
{
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Address { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool Active { get; set; } = true;
    public string MissionStatement { get; set; } = string.Empty;

    public ICollection<AppRole> Roles { get; set; } = [];
    public ICollection<Project> OrganizationProjects { get; set; } = [];
    public ICollection<Project> VolunteerProjects { get; set; } = [];
    //public ICollection<ProjectTask> VolunteerTasks { get; set; } = [];
    //public ICollection<TaskApplication> Applications { get; set; } = [];
}
