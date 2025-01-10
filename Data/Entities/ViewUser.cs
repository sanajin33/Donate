using Microsoft.AspNetCore.Identity;

namespace Donate.Data.Entities;

public class ViewUser : IdentityUser<int>
{
    public string? Name { get; set; }
    
    public string? Address { get; set; }
    
    public DateTime? CreatedAt { get; set; } 
    
    public bool? Active { get; set; } 

    public string? Role { get; set; }
}
