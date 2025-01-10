using System.ComponentModel.DataAnnotations;

namespace Donate.Data.Entities;

public class DonationItemType
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = "";

    [MaxLength(200)]
    public string? Description { get; set; }

    public bool Active { get; set; } = true;
 
    public ICollection<DonationItem> Items { get; set; } = [];
}
