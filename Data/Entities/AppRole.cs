using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Donate.Data.Entities;

public class AppRole : IdentityRole<int>
{
    public ICollection<AppUser> Users { get; set; } = [];
}
